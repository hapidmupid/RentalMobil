using Npgsql;
using RentalMobil.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace RentalMobil.Controller
{
    class TransaksiController
    {
        public bool CreateTransaksi(int idPelanggan, int idKendaraan,
                          DateTime tanggalSewa, DateTime tanggalKembali,
                          decimal hargaPerHari)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Hitung total hari dan harga
                        int hari = (tanggalKembali - tanggalSewa).Days;
                        decimal totalHarga = hari * hargaPerHari;

                        // 1. Buat transaksi
                        string queryTransaksi = @"
                            INSERT INTO transaksi 
                            (id_pelanggan, id_kendaraan, tanggal_sewa, tanggal_kembali, total_harga, status_pembayaran)
                            VALUES (@id_pelanggan, @id_kendaraan, @tanggal_sewa, @tanggal_kembali, @total_harga, 'belum_lunas')";

                        using (var cmd = new NpgsqlCommand(queryTransaksi, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_pelanggan", idPelanggan);
                            cmd.Parameters.AddWithValue("@id_kendaraan", idKendaraan);
                            cmd.Parameters.AddWithValue("@tanggal_sewa", tanggalSewa);
                            cmd.Parameters.AddWithValue("@tanggal_kembali", tanggalKembali);
                            cmd.Parameters.AddWithValue("@total_harga", totalHarga);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update status kendaraan
                        string queryUpdateKendaraan = @"
                            UPDATE kendaraan 
                            SET status = 'disewa' 
                            WHERE id_kendaraan = @id_kendaraan";

                        using (var cmd = new NpgsqlCommand(queryUpdateKendaraan, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_kendaraan", idKendaraan);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error saat membuat transaksi: {ex.Message}",
                                      "Database Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public int CreateTransaksiWithReturnId(int idPelanggan, int idKendaraan,
                                             DateTime tglSewa, DateTime tglKembali,
                                             decimal hargaPerHari)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Hitung total hari dan harga
                        int hari = (tglKembali - tglSewa).Days;
                        decimal totalHarga = hari * hargaPerHari;

                        // 1. Buat transaksi dan dapatkan ID
                        string queryTransaksi = @"
                            INSERT INTO transaksi 
                            (id_pelanggan, id_kendaraan, tanggal_sewa, tanggal_kembali, total_harga, status_pembayaran) 
                            VALUES (@id_pelanggan, @id_kendaraan, @tanggal_sewa, @tanggal_kembali, @total_harga, 'belum_lunas')
                            RETURNING id_transaksi";

                        using (var cmd = new NpgsqlCommand(queryTransaksi, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_pelanggan", idPelanggan);
                            cmd.Parameters.AddWithValue("@id_kendaraan", idKendaraan);
                            cmd.Parameters.AddWithValue("@tanggal_sewa", tglSewa);
                            cmd.Parameters.AddWithValue("@tanggal_kembali", tglKembali);
                            cmd.Parameters.AddWithValue("@total_harga", totalHarga);

                            int idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());

                            // 2. Update status kendaraan
                            string queryUpdateKendaraan = @"
                                UPDATE kendaraan 
                                SET status = 'disewa' 
                                WHERE id_kendaraan = @id_kendaraan";

                            using (var cmdUpdate = new NpgsqlCommand(queryUpdateKendaraan, conn, transaction))
                            {
                                cmdUpdate.Parameters.AddWithValue("@id_kendaraan", idKendaraan);
                                cmdUpdate.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return idTransaksi;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error saat membuat transaksi: {ex.Message}",
                                        "Database Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
        }

        public DataTable GetRiwayatByPelanggan(int idPelanggan)
        {
            DataTable dataTable = new DataTable();

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                t.id_transaksi,
                k.merk || ' ' || k.model as kendaraan,
                t.tanggal_sewa,
                t.tanggal_kembali,
                t.total_harga,
                t.status_pembayaran
            FROM 
                transaksi t
            JOIN 
                kendaraan k ON t.id_kendaraan = k.id_kendaraan
            WHERE 
                t.id_pelanggan = @id_pelanggan
            ORDER BY 
                t.tanggal_sewa DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pelanggan", idPelanggan);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetTransaksiBelumBayar(int idPelanggan)
        {
            DataTable dataTable = new DataTable();

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                t.id_transaksi,
                k.merk || ' ' || k.model as kendaraan,
                t.tanggal_sewa,
                t.tanggal_kembali,
                t.total_harga,
                t.status_pembayaran
            FROM 
                transaksi t
            JOIN 
                kendaraan k ON t.id_kendaraan = k.id_kendaraan
            WHERE 
                t.id_pelanggan = @id_pelanggan
                AND t.status_pembayaran = 'belum_lunas'
            ORDER BY 
                t.tanggal_sewa DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pelanggan", idPelanggan);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

    }
}