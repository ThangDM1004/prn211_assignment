using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmProductDetail : Form
    {
        public IProductRepository ProjectDetailsRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public FlowerBouquet ProductInfo { get; set; }
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if ( txtFLowerBouquetName.Text == "" || txtCategoryID.Text == "" ||
                txtDescription.Text == "" || txtSupplierID.Text == "" || txtUnitPrice.Text == "" || txtUnitsInStock.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Product Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var p = new FlowerBouquet
                    {
                       
                        FlowerBouquetName = txtFLowerBouquetName.Text,
                        FlowerBouquetStatus = byte.Parse(txtFlowerBouquetStatus.Text),
                        Description = txtDescription.Text,
                        SupplierId = int.Parse(txtSupplierID.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = int.Parse(txtUnitsInStock.Text),
                        CategoryId = int.Parse(txtCategoryID.Text),
                    };
                    if (InsertOrUpdate == false)
                    {
                        ProjectDetailsRepository.SaveProduct(p);
                        DialogResult d;
                        d = MessageBox.Show("Create Product Successfully, Are You Continue ?", "Notice",MessageBoxButtons.OKCancel);
                        if(d == DialogResult.OK)
                        {

                        }
                        else
                        {
                            Close();
                        }
                    }
                    else
                    {
                        p.FlowerBouquetId = int.Parse(txtFLowerBouquetID.Text);
                        ProjectDetailsRepository.UpdateProduct(p);
                        DialogResult d;
                      d =  MessageBox.Show("Update Product Successfully, Are You Continue ?", "Notice", MessageBoxButtons.OKCancel);
                        if (d == DialogResult.OK)
                        {

                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new project" : "Update a project");
            }
           

        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtFLowerBouquetID.Enabled = false;
            if (InsertOrUpdate)
            {
                txtFLowerBouquetID.Text = ProductInfo.FlowerBouquetId.ToString();
                txtCategoryID.Text = ProductInfo.CategoryId.ToString();
                txtDescription.Text = ProductInfo.Description.ToString();
                txtFLowerBouquetName.Text = ProductInfo.FlowerBouquetName.ToString();
                txtFlowerBouquetStatus.Text = ProductInfo.FlowerBouquetStatus.ToString();
                txtSupplierID.Text = ProductInfo.SupplierId.ToString();
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfo.UnitsInStock.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
