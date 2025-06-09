// PembayaranController.cs
using Npgsql;
using RentalMobil.Models;
using System;
using System.Windows.Forms;

namespace RentalMobil.Controller
{
    public class PembayaranController
    {
        public bool CreatePembayaran(int idTransaksi, decimal jumlah, string metodePembayaran)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert data pembayaran
                        string query = @"
                            INSERT INTO pembayaran 
                            (id_transaksi, jumlah, metode_pembayaran, tanggal_pembayaran) 
                            VALUES (@id_transaksi, @jumlah, @metode_pembayaran, CURRENT_TIMESTAMP)";

                        using (var cmd = new NpgsqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                            cmd.Parameters.AddWithValue("@jumlah", jumlah);
                            cmd.Parameters.AddWithValue("@metode_pembayaran", metodePembayaran);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update status transaksi
                        string updateTransaksi = @"
                            UPDATE transaksi 
                            SET status_pembayaran = 'lunas' 
                            WHERE id_transaksi = @id_transaksi";

                        using (var cmd = new NpgsqlCommand(updateTransaksi, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error saat menyimpan pembayaran: {ex.Message}",
                                      "Database Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}