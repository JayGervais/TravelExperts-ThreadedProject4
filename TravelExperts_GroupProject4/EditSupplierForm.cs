using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts_GroupProject4
{
    public partial class EditSupplierForm : Form
    {
        public EditSupplierForm(string supplierName, int supplierId, int productId, string productName)
        {
            InitializeComponent();

            txtSupplierName.Text = supplierName;
            txtSupplierID.Text = Convert.ToString(supplierId);
            txtProductID.Text = Convert.ToString(productId);
            txtProductName.Text = productName;

        }

    }
}
