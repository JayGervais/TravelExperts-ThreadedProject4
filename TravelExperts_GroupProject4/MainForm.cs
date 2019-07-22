﻿using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnPackages_Click(object sender, EventArgs e)
        {
            new TravelPackageForm().Show();
            Hide();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm supplierListForm = new SupplierForm();
            supplierListForm.Show();
        }
    }
}
