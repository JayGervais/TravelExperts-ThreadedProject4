using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsData
{
    public class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            //string connectionString = @"Data Source=localhost\SAITSQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            //string connectionString = @"Data Source=localhost\SAIT;Initial Catalog=TravelExperts;Integrated Security=True";
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }

        internal static SqlConnection GetConnection(ListView listView, object supplierList, int v, object supplierId)
        {
            throw new NotImplementedException();
        }
    }
}
