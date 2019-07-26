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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();

            List<Supplier> item = TravelSupplierDB.GetSupplier(lstViewSupplier);

            //lbSupplier.DataSource = item;
            //dataGridViewSupplier.DataSource = TravelSupplierDB.GetSupplier(supplierID);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string supplierName =lblSupName.Text;
            int supplierId = Convert.ToInt32(lblSupID.Text);
            int productId = Convert.ToInt32(lblProdId.Text);
            string productName = lblProdName.Text;

            EditSupplierForm supplierListForm = new EditSupplierForm(supplierName, supplierId, productId, productName);
            //EditSupplierForm supplierListForm = new EditSupplierForm();
            supplierListForm.Show();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierForm supplierListForm = new AddSupplierForm();
            supplierListForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
