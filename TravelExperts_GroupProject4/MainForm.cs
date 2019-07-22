using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExperts_GroupProject4
{
    public partial class HomePage : Form
    {
        List<PackageHC> packageList;  // List of Packages
        List<Supplier> supplierList, engagedSuppliers;
        List<Product> productList, engagedProducts;
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnPackages_Click(object sender, EventArgs e)
        {
            new TravelPackageForm().Show();
            Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            GetHomePageInfo();            
        }

        private void GetHomePageInfo()
        {
            List<int> duration = new List<int>();
            int rows, rowDuration, minDuration, maxDuration;
            //int rowDuration;
            decimal MinBasePrice, MaxBasePrice;

            packageList = PackageDB.GetPackages();
            rows = packageList.Count;
            txtPackageCount.Text = rows.ToString();

            MinBasePrice = packageList.Min(r => r.PkgBasePrice);
            txtMinBasePrice.Text = MinBasePrice.ToString("c");
            MaxBasePrice = packageList.Max(r => r.PkgBasePrice);
            txtMaxBasePrice.Text = MaxBasePrice.ToString("c");

            for (int i = 0; i < rows; i++)
            {
                rowDuration = (int)((DateTime)packageList[i].PkgEndDate - (DateTime)packageList[i].PkgStartDate).TotalDays;
                duration.Add(rowDuration);
            }

            minDuration = duration.Min();
            txtMinDuration.Text = minDuration.ToString();
            maxDuration = duration.Max();
            txtMaxDuration.Text = maxDuration.ToString();

            supplierList = SupplierDB.GetSuppliers();
            txtTotalNumSuppliers.Text = supplierList.Count.ToString();

            engagedSuppliers = SupplierDB.GetEngagedSuppliers();
            txtEngagedSuppliers.Text = engagedSuppliers.Count.ToString();

            productList = ProductDB.GetProducts();
            txtTotalNumProducts.Text = productList.Count.ToString();

            engagedProducts = ProductDB.GetEngagedProducts();
            txtEngagedProducts.Text = engagedProducts.Count.ToString();
        }
    }
}
