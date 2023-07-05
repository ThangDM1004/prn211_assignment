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
    public partial class frmMain : Form
    {
        BindingSource source;
        ICustomerRepository cus = new CustomerRepository();
        public string UserRole { get; set; }
        public string Email { get; set; }
        public int UserID { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (UserRole != "Admin")
            {
                btnCreate.Visible = false;
                btnDelete.Visible = false;
                LoadCustomerList(cus.GetAllCustomerByID(UserID));
            }
            else
            {
                btnCreate.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                LoadCustomerList(cus.GetAllCustomer());
            }

        }
        private void ClearText()
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtBirthday.Text = string.Empty;
        }
        public void LoadCustomerList(List<Customer> list)
        {

            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtCustomerID.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtBirthday.DataBindings.Clear();

                txtCustomerID.DataBindings.Add("Text", source, "CustomerID"); ;
                txtCustomerName.DataBindings.Add("Text", source, "CustomerName"); ;
                txtEmail.DataBindings.Add("Text", source, "Email"); ;
                txtPassword.DataBindings.Add("Text", source, "Password"); ;
                txtCountry.DataBindings.Add("Text", source, "Country"); ;
                txtCity.DataBindings.Add("Text", source, "City"); ;
                txtBirthday.DataBindings.Add("Text", source, "Birthday"); ;


                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = source;
                if (list.Count() == 0)
                {
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Customer list");
            }
        }
        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetailInfo frmDetailInfo = new frmDetailInfo();
            frmDetailInfo.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.proRole = UserRole;
            frmProduct.CustomerID_pro = UserID;
            frmProduct.proEmail = Email;
            frmProduct.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.orderRole = UserRole;
            frmOrder.CustomerID_order = UserID;
            frmOrder.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDetailInfo details = new frmDetailInfo
            {
                Text = "Update Product",
                InsertOrUpdateCus = true,
                CusInfo = GetCustomer(),
                CusDetailRepository = cus
            };
            if (details.ShowDialog() == DialogResult.Cancel)
            {
                LoadCustomerList(cus.GetAllCustomer());
            }
        }
        private Customer GetCustomer()
        {
            Customer cus = null;
            try
            {
                cus = new Customer
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    CustomerName = txtCustomerName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Birthday = DateTime.Parse(txtBirthday.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Project");
            }
            return cus;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmDetailInfo details = new frmDetailInfo
            {
                Text = "Add Product",
                InsertOrUpdateCus = false,
                CusDetailRepository = cus
            };
            if (details.ShowDialog() == DialogResult.Cancel)
            {
                LoadCustomerList(cus.GetAllCustomer());
                source.Position = source.Position - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this account?", "Account Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var p = new Customer
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                };
                cus.DeleteCustomer(p);
                LoadCustomerList(cus.GetAllCustomer());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
