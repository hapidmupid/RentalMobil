using Npgsql;
using RentalMobil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Controller
{
    class PelangganController
    {
        public List<Pelanggan> GetAllPelanggan()
        {
            List<Pelanggan> pelangganList = new List<Pelanggan>();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM pelanggan";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pelanggan pelanggan = new Pelanggan
                            {
                                id_pelanggan = Convert.ToInt32(reader["id_pelanggan"]),
                                nama = reader["nama"].ToString(),
                                alamat = reader["alamat"].ToString(),
                                no_telp = reader["no_telp"].ToString(),
                                email = reader["email"].ToString(),
                                username = reader["username"].ToString(),
                                password = reader["password"].ToString()
                            };
                            pelangganList.Add(pelanggan);
                        }
                    }
                }
            }
            return pelangganList;
        }

        public bool DeletePelanggan(int id)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM pelanggan WHERE id_pelanggan = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public Pelanggan GetPelangganById(int id)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM pelanggan WHERE id_pelanggan = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Pelanggan
                            {
                                id_pelanggan = Convert.ToInt32(reader["id_pelanggan"]),
                                nama = reader["nama"].ToString(),
                                alamat = reader["alamat"].ToString(),
                                no_telp = reader["no_telp"].ToString(),
                                email = reader["email"].ToString(),
                                username = reader["username"].ToString(),
                                password = reader["password"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool UpdatePelanggan(Pelanggan pelanggan)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = @"UPDATE pelanggan 
                                SET nama = @nama, alamat = @alamat, no_telp = @no_telp, 7
                                    email = @email, username = @username, password = @password 
                                WHERE id_pelanggan = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", pelanggan.id_pelanggan);
                    cmd.Parameters.AddWithValue("@nama", pelanggan.nama);
                    cmd.Parameters.AddWithValue("@alamat", pelanggan.alamat);
                    cmd.Parameters.AddWithValue("@no_telp", pelanggan.no_telp);
                    cmd.Parameters.AddWithValue("@email", pelanggan.email);
                    cmd.Parameters.AddWithValue("@username", pelanggan.username);
                    cmd.Parameters.AddWithValue("@password", pelanggan.password);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        
    }

}
