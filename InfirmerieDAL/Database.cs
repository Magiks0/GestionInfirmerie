using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    public class Database
    {
        static bool Connect()
        {
            SqlConnection DbConnect = new SqlConnection("Persist Security Info=False; Trusted_Connection=True; database=GestionInfirmerie; server=(local)");
            try
            {
                DbConnect.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    }
}
