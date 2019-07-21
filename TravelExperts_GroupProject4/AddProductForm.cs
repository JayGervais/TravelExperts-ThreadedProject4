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
/// <summary>
/// Add Product Form Created by Jay Gervais
/// </summary>
namespace TravelExperts_GroupProject4
{
    public partial class AddProductForm : Form
    {
        public AddProductForm(int packageId, string packageName)
        {
            InitializeComponent();

            lblPackageName.Text = packageName;
            lblPackageId.Text = Convert.ToString(packageId);

            if (lstProducts.Items != null)
            {
                List<Package> packageProducts = TravelPackageDB.GetPackageProducts(lstProducts, packageId);
                List<Package> showProducts = TravelPackageDB.ShowAllProducts(lstAllProducts, packageId);
            }
        }

        private void BtnRemoveProduct_Click(object sender, EventArgs e)
        {
            int packageId = Convert.ToInt32(lblPackageId.Text);
            int productId = Convert.ToInt32(lblProductId.Text);

            TravelPackageDB removeProduct = new TravelPackageDB();
            removeProduct.RemovePackageProduct(productId, packageId);
            List<Package> refreshProducts = TravelPackageDB.GetPackageProducts(lstProducts, packageId);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int packageId = Convert.ToInt32(lblPackageId.Text);
            int productId = Convert.ToInt32(lblListNewProd.Text);

            TravelPackageDB getProdSupplierId = new TravelPackageDB();
            int supplierId = getProdSupplierId.GetSupplierId(productId);
            getProdSupplierId.AddPackageToProd(Convert.ToInt32(lblPackageId.Text), supplierId);
            List<Package> refreshProducts = TravelPackageDB.GetPackageProducts(lstProducts, packageId);
        }

        private void LstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelPackageDB getProdId = new TravelPackageDB();
            getProdId.GetProductId(lstProducts.Text, lblProductId);
        }

        private void LstAllProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelPackageDB getProdId = new TravelPackageDB();
            getProdId.GetProductId(lstAllProducts.Text, lblListNewProd);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
