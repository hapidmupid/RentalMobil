using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Models
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }
        public int id_pelanggan { get; set; }
        public int id_kendaraan { get; set; }
        public DateTime tanggal_sewa { get; set; }
        public DateTime tanggal_kembali { get; set; }
        public decimal total_harga { get; set; }
        public string status_pembayaran { get; set; }
    }
}
