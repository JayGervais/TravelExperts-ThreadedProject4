using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class PackageDB
    {

        public static List<PackageHC> GetPackages()
        {
            List<PackageHC> packages = new List<PackageHC>();   // empty list
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, " +
                    "PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                    "FROM Packages";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        PackageHC pkg;
                        while (reader.Read())
                        {
                            pkg = new PackageHC();
                            pkg.PackageId = (int)reader["PackageId"];
                            pkg.PkgName = reader["PkgName"].ToString();

                            // for any column that can be null need to determine if it is DBNull
                            // and set accordingly
                            int colSD = reader.GetOrdinal("PkgStartDate"); // column number of PkgStartDate
                            if (reader.IsDBNull(colSD)) // if reader contains DBNull in this column
                                pkg.PkgStartDate = null; // make it null in the object
                            else // it is not null
                                pkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);

                            int colED = reader.GetOrdinal("PkgEndDate"); // column number of PkgEndDate
                            if (reader.IsDBNull(colED)) // if reader contains DBNull in this column
                                pkg.PkgEndDate = null; // make it null in the object
                            else // it is not null
                                pkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);

                            pkg.PkgDesc = reader["PkgDesc"].ToString();
                            pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                            int colAC = reader.GetOrdinal("PkgAgencyCommission"); // column number of PkgAgencyCommission
                            if (reader.IsDBNull(colAC)) // if reader contains DBNull in this column
                                pkg.PkgAgencyCommission = null; // make it null in the object
                            else // it is not null
                                pkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];

                            packages.Add(pkg);
                        }
                    }
                }
            }
            return packages;
        }

        public static PackageHC GetPackageById(int packageId)
        {
            PackageHC selectedPkg = new PackageHC();
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, " +
                    "PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                    "FROM Packages " +
                    "WHERE PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read())  // if package with given ID exists
                    {
                        selectedPkg = new PackageHC();
                        selectedPkg.PackageId = (int)reader["PackageId"];
                        selectedPkg.PkgName = reader["PkgName"].ToString();

                        // for any column that can be null need to determine if it is DBNull
                        // and set accordingly
                        int colSD = reader.GetOrdinal("PkgStartDate"); // column number of PkgStartDate
                        if (reader.IsDBNull(colSD)) // if reader contains DBNull in this column
                            selectedPkg.PkgStartDate = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);

                        int colED = reader.GetOrdinal("PkgEndDate"); // column number of PkgEndDate
                        if (reader.IsDBNull(colED)) // if reader contains DBNull in this column
                            selectedPkg.PkgEndDate = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);

                        selectedPkg.PkgDesc = reader["PkgDesc"].ToString();
                        selectedPkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                        int colAC = reader.GetOrdinal("PkgAgencyCommission"); // column number of PkgAgencyCommission
                        if (reader.IsDBNull(colAC)) // if reader contains DBNull in this column
                            selectedPkg.PkgAgencyCommission = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                    }
                }
            }
            return selectedPkg;
        }

    }
}
