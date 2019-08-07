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
    public partial class SupplierwithProductForm : Form
    {
        public SupplierwithProductForm(string supplierId, string supplierName, string productId, string productName)
        {
            InitializeComponent();

            txtSupplierID.Text = supplierId;
            txtSupplierName.Text = supplierName;
            txtProductID.Text = productId;
            txtProductName.Text = productName;
        }
    }
}
