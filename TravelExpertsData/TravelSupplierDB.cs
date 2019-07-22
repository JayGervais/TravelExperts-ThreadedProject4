using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsData
{
    public class TravelSupplierDB
    {
        /*
        public static List<Supplier> GetSupplier(ListView tableView)
        {
            List<Supplier> suppliers = new List<Supplier>();

            //Supplier information = null;

            //sql connection 
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectSuppliersQuery = @"SELECT SupplierId, SupName FROM Suppliers";
                using (SqlCommand cmd = new SqlCommand(selectSuppliersQuery, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", tableView);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    tableView.View = View.Details;
                    tableView.FullRowSelect = true;

                    tableView.Columns.Add("SupplierID").Width = 100;
                    tableView.Columns.Add("SupplierName").Width = 100;

                    while (reader.Read())
                    {
                        var item = new ListViewItem();
                        // variables
                        int supplierID = Convert.ToInt32(reader["SupplierId"]);
                        char supplierName = Convert.ToChar(reader["SupName"]);


                        item.SubItems[0].Text = reader[0].ToString();
                        item.SubItems.Add(reader["SupplierId"].ToString());
                        item.SubItems.Add(reader["SupName"].ToString());
                        tableView.Items.Add(item);

                        //information = new Supplier();
                        //information.SupplierID = Convert.ToInt16(reader["SupplierId"]);
                        //information.SupplierID = Convert.ToChar(reader["SupplierName"]);
                        //suppliers.Add(information);
                    }
                } 
            }
            return suppliers;
        }*/

        public static List<Supplier> GetSupplier(int supplierID)
        {
            List<Supplier> suppliers = new List<Supplier>();

            Supplier info = null;

            //sql connection 
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectSuppliersQuery = @"SELECT SupplierId, SupName FROM Suppliers WHERE SupplierId = @SupplierId";
                using (SqlCommand cmd = new SqlCommand(selectSuppliersQuery, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", supplierID);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            info = new Supplier();
                            info.SupplierID = Convert.ToInt16(reader["SupplierId"]);
                            info.SupplierName = Convert.ToChar(reader["SupplierName"]);
                            suppliers.Add(info);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return suppliers;
        }
    }//class end
}//name space end
