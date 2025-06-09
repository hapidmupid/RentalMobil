using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMobil.Models
{
    class Database
    {
        private static string connectionString = "Host=localhost;Username=postgres;Password=12345;Database=dbRentalMobil";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
