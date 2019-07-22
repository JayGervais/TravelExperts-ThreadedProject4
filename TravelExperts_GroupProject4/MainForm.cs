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
            decimal MinBasePrice, MaxBasePrice;
            packageList = PackageDB.GetPackages();
            txtPackageCount.Text = packageList.Count.ToString();
            MinBasePrice = packageList.Min(r => r.PkgBasePrice);
            txtMinBasePrice.Text = MinBasePrice.ToString("c");
            MaxBasePrice = packageList.Max(r => r.PkgBasePrice);
            txtMaxBasePrice.Text = MaxBasePrice.ToString("c");
        }
    }
}
