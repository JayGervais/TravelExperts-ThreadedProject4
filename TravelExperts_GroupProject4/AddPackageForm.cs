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
    public partial class AddPackageForm : Form
    {
        public AddPackageForm()
        {
            InitializeComponent();
        }

        private void AddPackageForm_Load(object sender, EventArgs e)
        {
            List<Package> packageView = TravelPackageDB.GetPackages(lstViewTravelPackages);


        }

        private void LstViewTravelPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelPackageDB packageDetails = new TravelPackageDB();
            packageDetails.ShowSelectedOrder(lstViewTravelPackages, lblPackageName, lblStartDate, lblEndDate, lblDescription, lblBasePrice, lblCommission);
        }
    }
}
