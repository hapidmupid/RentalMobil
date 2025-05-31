using Npgsql;
using RentalMobil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Controller
{
    class AuthController
    {
        public static Admin LoginAdmin(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM admin WHERE username=@username AND password=@password", conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Admin
                            {
                                id_admin = reader.GetInt32(0),
                                nama = reader.GetString(1),
                                username = reader.GetString(2),
                                password = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static Pelanggan LoginPelanggan(string username, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM pelanggan WHERE username=@username AND password=@password", conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Pelanggan
                            {
                                id_pelanggan = reader.GetInt32(0),
                                email = reader.GetString(1),
                                nama = reader.GetString(2),
                                no_telp = reader.GetString(3),
                                username = reader.GetString(4),
                                password = reader.GetString(5),
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static bool RegisterPelanggan(Pelanggan pelanggan)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "INSERT INTO pelanggan (email, nama, no_telp, username, password) " +
                    "VALUES (@email, @nama, @no_telp, @username, @password)", conn))
                {
                    cmd.Parameters.AddWithValue("email", pelanggan.email);
                    cmd.Parameters.AddWithValue("nama", pelanggan.nama);
                    cmd.Parameters.AddWithValue("no_telp", pelanggan.no_telp);
                    cmd.Parameters.AddWithValue("username", pelanggan.username);
                    cmd.Parameters.AddWithValue("password", pelanggan.password);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
