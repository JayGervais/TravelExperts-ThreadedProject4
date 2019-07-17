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
    public partial class EditPackageForm : Form
    {
        public EditPackageForm(string packageId, string packageName, DateTime packageStartDate, DateTime packageEndDate, string packageDescription, string packageBasePrice, string packageCommission)
        {
            InitializeComponent();

            txtPackageID.Text = packageId;
            txtPackageName.Text = packageName;
            dateStart.Value = packageStartDate;
            dateEnd.Value = packageEndDate;
            txtPackageDesc.Text = packageDescription;
            txtBasePrice.Text = packageBasePrice;
            txtCommission.Text = packageCommission;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
