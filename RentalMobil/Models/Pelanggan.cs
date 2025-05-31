using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Models
{
    public class Pelanggan
    {
        public int id_pelanggan { get; set; }
        public string email { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string no_telp { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
