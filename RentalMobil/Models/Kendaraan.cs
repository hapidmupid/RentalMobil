using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Models
{
    public class Kendaraan
    {
        public int id_kendaraan { get; set; }
        public string merk { get; set; }
        public string model { get; set; }
        public int tahun { get; set; }
        public string nomor_plat { get; set; }
        public decimal harga_sewa_perhari { get; set; }
        public string status { get; set; }
        public string gambar { get; set; }
    }
}
