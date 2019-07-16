using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExperts_GroupProject4
{
    public class TravelPackageDB
    {

        public static List<Package> GetPackages(ListView tableView)
        {
            List<Package> packages = new List<Package>();

            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectPackagesQuery = @"SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages";
                using (SqlCommand cmd = new SqlCommand(selectPackagesQuery, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    tableView.View = View.Details;
                    tableView.FullRowSelect = true;

                    tableView.Columns.Add("ID").Width=35;
                    tableView.Columns.Add("Name").Width = 125;
                    tableView.Columns.Add("Start Date").Width = 85;
                    tableView.Columns.Add("End Date").Width = 85;
                    tableView.Columns.Add("Description").Width = 300;
                    tableView.Columns.Add("Base Price").Width = 65;
                    tableView.Columns.Add("Commission").Width = 75;

                    while (reader.Read())
                    {
                        var item = new ListViewItem();
                        // variables
                        DateTime startDate = Convert.ToDateTime(reader["PkgStartDate"]);
                        DateTime endDate = Convert.ToDateTime(reader["PkgEndDate"]);
                        double basePrice = Convert.ToDouble(reader["PkgBasePrice"]);
                        double agencyCommission = Convert.ToDouble(reader["PkgAgencyCommission"]);

                        item.SubItems[0].Text = reader[0].ToString();
                        item.SubItems.Add(reader["PkgName"].ToString());
                        item.SubItems.Add(startDate.ToString("MM/dd/yyyy"));
                        item.SubItems.Add(endDate.ToString("MM/dd/yyyy"));
                        item.SubItems.Add(reader["PkgDesc"].ToString());
                        item.SubItems.Add(basePrice.ToString("C"));
                        item.SubItems.Add(agencyCommission.ToString("C"));
                        tableView.Items.Add(item);
                    }
                }
            }
            return packages;
        }

        public void ShowSelectedOrder(ListView listview, Label packageName, Label packageStartDate, Label packageEndDate, Label packageDescription, Label packageBasePrice, Label packageCommission)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string selectPackageQuery = @"SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages WHERE PackageId = @PackageId";

                SqlCommand sqlCommand = new SqlCommand(selectPackageQuery, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    if (listview != null && listview.SelectedItems.Count > 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@PackageId", listview.FocusedItem.Text);

                        DataTable OrderDataTable = new DataTable();
                        sqlDataAdapter.Fill(OrderDataTable);

                        // variables
                        string pkgId = Convert.ToString(OrderDataTable.Rows[0]["PackageId"]);
                        string pkgName = Convert.ToString(OrderDataTable.Rows[0]["PkgName"]);
                        string pkgDesc = Convert.ToString(OrderDataTable.Rows[0]["PkgDesc"]);
                        DateTime startDate = Convert.ToDateTime(OrderDataTable.Rows[0]["PkgStartDate"]);
                        DateTime endDate = Convert.ToDateTime(OrderDataTable.Rows[0]["PkgEndDate"]);
                        double pkgPrice = Convert.ToDouble(OrderDataTable.Rows[0]["PkgBasePrice"]);
                        double pkgComm = Convert.ToDouble(OrderDataTable.Rows[0]["PkgAgencyCommission"]);

                        packageName.Text = pkgName;
                        packageStartDate.Text = startDate.ToString("MM/dd/yyyy");
                        packageEndDate.Text = endDate.ToString("MM/dd/yyyy");
                        packageDescription.Text = pkgDesc;
                        packageBasePrice.Text = pkgPrice.ToString("C");
                        packageCommission.Text = pkgComm.ToString("C");
                    }
                }
            }
            catch (Exception)
            {
                //throw ex;
            }
            finally
            {
                con.Close();
            }
        }



    }
}
