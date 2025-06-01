using Npgsql;
using RentalMobil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Controller
{
    class KendaraanController
    {
        public List<Kendaraan> GetAllKendaraan()
        {
            List<Kendaraan> kendaraanList = new List<Kendaraan>();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM kendaraan";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kendaraanList.Add(new Kendaraan
                            {
                                id_kendaraan = Convert.ToInt32(reader["id_kendaraan"]),
                                merk = reader["merk"].ToString(),
                                model = reader["model"].ToString(),
                                tahun = Convert.ToInt32(reader["tahun"]),
                                nomor_plat = reader["nomor_plat"].ToString(),
                                harga_sewa_perhari = Convert.ToDecimal(reader["harga_sewa_perhari"]),
                                status = reader["status"].ToString(),
                            });
                        }
                    }
                }
            }
            return kendaraanList;
        }


        public Kendaraan GetKendaraanById(int id)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM kendaraan WHERE id_kendaraan = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Kendaraan
                            {
                                id_kendaraan = Convert.ToInt32(reader["id_kendaraan"]),
                                merk = reader["merk"].ToString(),
                                model = reader["model"].ToString(),
                                tahun = Convert.ToInt32(reader["tahun"]),
                                nomor_plat = reader["nomor_plat"].ToString(),
                                harga_sewa_perhari = Convert.ToDecimal(reader["harga_sewa_perhari"]),
                                status = reader["status"].ToString(),
                            };
                        }
                    }
                }
            }
            return null;

        }

            

        public bool DeleteKendaraan(int id)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM kendaraan WHERE id_kendaraan = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AddKendaraan(Kendaraan kendaraan)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = @"INSERT INTO kendaraan (merk, model, tahun, nomor_plat, harga_sewa_perhari, status) 
                                 VALUES (@merk, @model, @tahun, @plat, @harga, @status)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@merk", kendaraan.merk);
                    cmd.Parameters.AddWithValue("@model", kendaraan.model);
                    cmd.Parameters.AddWithValue("@tahun", kendaraan.tahun);
                    cmd.Parameters.AddWithValue("@plat", kendaraan.nomor_plat);
                    cmd.Parameters.AddWithValue("@harga", kendaraan.harga_sewa_perhari);
                    cmd.Parameters.AddWithValue("@status", kendaraan.status);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateKendaraan(Kendaraan kendaraan)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = @"UPDATE kendaraan 
                                SET merk = @merk, 
                                    model = @model, 
                                    tahun = @tahun, 
                                    nomor_plat = @plat, 
                                    harga_sewa_perhari = @harga, 
                                    status = @status
                                WHERE id_kendaraan = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", kendaraan.id_kendaraan);
                    cmd.Parameters.AddWithValue("@merk", kendaraan.merk);
                    cmd.Parameters.AddWithValue("@model", kendaraan.model);
                    cmd.Parameters.AddWithValue("@tahun", kendaraan.tahun);
                    cmd.Parameters.AddWithValue("@plat", kendaraan.nomor_plat);
                    cmd.Parameters.AddWithValue("@harga", kendaraan.harga_sewa_perhari);
                    cmd.Parameters.AddWithValue("@status", kendaraan.status);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
