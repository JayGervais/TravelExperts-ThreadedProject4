﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts_GroupProject4;

// Product form written by Justin Murphey
namespace Product2
{
    public partial class ProductForm : Form
    {
      
        private object product;
       
        public ProductForm()
        {
            InitializeComponent();
          
        }
        public string oldprodname = null;
        private void ProductForm_Load(object sender, EventArgs e)
        {
          
            try
            {
                product = Product_DB.GetAllProducts();
                productDataGridView.DataSource = product;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading customers data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];
                txtUpdate.Text = row.Cells["DataGridViewTextBoxColumn2"].Value.ToString();
                oldprodname = txtUpdate.Text;
            }

            }

        private void txtCreate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCreate.Text != null) {
                Product_DB.AddProduct(txtCreate.Text);
                txtCreate.Text = "";
                    }
            product = Product_DB.GetAllProducts();
            productDataGridView.DataSource = product;
            this.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtUpdate.Text != null)
            {
                Product_DB.UpdateProduct(txtUpdate.Text, oldprodname);
                txtUpdate.Text = "";
            }
            product = Product_DB.GetAllProducts();
            productDataGridView.DataSource = product;
            this.Refresh();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (txtUpdate.Text != null)
            {
                string deactivate = ("inactive" + txtUpdate.Text);
                Product_DB.UpdateProduct(deactivate, oldprodname);
                txtUpdate.Text = "";
            }
            product = Product_DB.GetAllProducts();
            productDataGridView.DataSource = product;
            this.Refresh();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Close();
        }
    }
}
