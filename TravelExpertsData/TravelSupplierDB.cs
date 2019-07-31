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
       
        public static List<Supplier> GetSupplier(ListView tableView)
        {
            List<Supplier> suppliers = new List<Supplier>();

            //sql connection 
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectSuppliersQuery = @"SELECT SupName, [dbo].[Products_Suppliers].SupplierId, [dbo].[Products].ProductId, [dbo].[Products].ProdName
                FROM Suppliers
                INNER JOIN Products_Suppliers ON[dbo].[Suppliers].SupplierId  = [dbo].[Products_Suppliers].SupplierId
                INNER JOIN Products ON[dbo].[Products_Suppliers].ProductId = [dbo].[Products].ProductId
                ORDER BY ProductId";
                //string selectSuppliersQuery = @"SELECT SupplierId, SupName FROM Suppliers";
                using (SqlCommand cmd = new SqlCommand(selectSuppliersQuery, con))
                {                 
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    tableView.View = View.Details;
                    tableView.FullRowSelect = true;

                    tableView.Columns.Add("SupplierName").Width = 200;
                    tableView.Columns.Add("SupplierID").Width =100;
                    tableView.Columns.Add("ProductID").Width = 100;
                    tableView.Columns.Add("ProductName").Width = 200;

                    while (reader.Read())
                    {
                        var item = new ListViewItem();
                        // variables

                        //item.SubItems.Add(reader["SupName"].ToString());
                        item.SubItems[0].Text = reader[0].ToString();
                        item.SubItems.Add(reader["SupplierId"].ToString());
                        item.SubItems.Add(reader["ProductId"].ToString());
                        item.SubItems.Add(reader["ProdName"].ToString());
                        tableView.Items.Add(item);
                    }
                } 
            }
            return suppliers;
        }

        public void AddSupplier(string supplierName, int supplierId, int productId, string productName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string addSupQuery = @"INSERT INTO Suppliers " +
                                         "(SupName, SupplierID, ProductId, ProdName) " +
                                        "VALUES (@SupplierName, @SupplierID, @ProductID, @ProductName)";
                                        

                SqlCommand sqlCommand = new SqlCommand(addSupQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@PackageName", supplierName);
                sqlCommand.Parameters.AddWithValue("@PackageStartDate", supplierId);
                sqlCommand.Parameters.AddWithValue("@PackageEndDate", productId);
                sqlCommand.Parameters.AddWithValue("@PackageDescription", productName);
                sqlCommand.ExecuteScalar();
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

        public void EditSupplier(string supplierName, int supplierId, int productId, string productName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string updateSupQuery = @"UPDATE Suppliers " +
                                        "SET SupName = @SupplierName, SupplierID = @SupplierID, ProductId = @ProductID, ProdName = @ProductName" +
                                        "WHERE SupplierID = @SupplierID";

                SqlCommand sqlCommand = new SqlCommand(updateSupQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@PackageName", supplierName);
                sqlCommand.Parameters.AddWithValue("@PackageStartDate", supplierId);
                sqlCommand.Parameters.AddWithValue("@PackageEndDate", productId);
                sqlCommand.Parameters.AddWithValue("@PackageDescription", productName);
                sqlCommand.ExecuteScalar();

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

        public void DeleteSupplier(ListView supplierList, int supplierId)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();

            try
            {
                string deleteSupQuery = @"DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
                SqlCommand sqlCommand = new SqlCommand(deleteSupQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@SupplierID", supplierId);
                sqlCommand.ExecuteScalar();
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

    }//class end
}//name space end
