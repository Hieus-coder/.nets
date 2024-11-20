using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MobileShop
{
    class KetNoi
    {
        string conStr = @"Data Source=LAPTOP-EGMSJUVU\MAYHIEU;Initial Catalog=MobileShop;Integrated Security=True;";
        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataSet LayDuLieu(string truyvan)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            return ds; 
        }

        public bool ThucThi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
