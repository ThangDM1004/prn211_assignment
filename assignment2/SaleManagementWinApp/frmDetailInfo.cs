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
    public partial class frmDetailInfo : Form
    {
        public ICustomerRepository CusDetailRepository { get; set; }
        public bool InsertOrUpdateCus { get; set; }
        public Customer CusInfo { get; set; }
        public frmDetailInfo()
        {
            InitializeComponent();
        }

        private void frmDetailInfo_Load(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            if (InsertOrUpdateCus)
            {
                txtCustomerID.Text = CusInfo.CustomerId.ToString();
                txtCustomerName.Text = CusInfo.CustomerName.ToString();
                txtBirthday.Text = CusInfo.Birthday.ToString();
                txtCity.Text = CusInfo.City.ToString();
                txtCountry.Text = CusInfo.Country.ToString();
                txtEmail.Text = CusInfo.Email.ToString();
                txtPassword.Text = CusInfo.Password.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBirthday.Text == "" || txtCity.Text == "" ||
                txtCountry.Text == "" || txtCustomerName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Product Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var p = new Customer
                    {

                        CustomerName = txtCustomerName.Text,
                        Birthday = DateTime.Parse(txtBirthday.Text),
                        Country = txtCountry.Text,
                        City = txtCity.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                    };
                    if (InsertOrUpdateCus == false)
                    {
                        CusDetailRepository.SaveCustomer(p);
                        DialogResult d;
                        d = MessageBox.Show("Create Customer Successfully, Are You Continue ?", "Notice", MessageBoxButtons.OKCancel);
                        if (d == DialogResult.OK)
                        {

                        }
                        else
                        {
                            Close();
                        }
                    }
                    else
                    {
                        p.CustomerId = int.Parse(txtCustomerID.Text);
                        CusDetailRepository.UpdateCustomer(p);
                        DialogResult d;
                        d = MessageBox.Show("Update Customer Successfully, Are You Continue ?", "Notice", MessageBoxButtons.OKCancel);
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
                MessageBox.Show(ex.Message, InsertOrUpdateCus == false ? "Add new project" : "Update a project");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
