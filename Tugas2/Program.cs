using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }
        public void Connecting()
        {
            using (SqlConnection con = new SqlConnection("data source=LAPTOP-EG0BMCQV\\FAISHAL;database=Penyewaan;User ID=sa;Password=123"))
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database!");
            }
        }
    }
}
