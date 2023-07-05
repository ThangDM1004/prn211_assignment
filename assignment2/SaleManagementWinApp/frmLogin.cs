using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using Repositories;
using BusinessObjects;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        ICustomerRepository m = new CustomerRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IConfiguration builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            var email = builder["AdminAccount:AdminEmail"];
            var pass = builder["AdminAccount:AdminPass"];
            if (txtEmail.Text.Equals(email) && txtPass.Text.Equals(pass))
            {
                frmMain m = new frmMain();
                m.UserRole = "Admin";
                m.ShowDialog();
            }
            else if (txtEmail.Text.Equals(email) && !txtPass.Text.Equals(txtPass))
            {
                MessageBox.Show("Email or Password incorrect !!!");
            }
            else
            {
                Customer user = m.getMemberByEmail(txtEmail.Text);
                if (user != null)
                {
                    if (txtEmail.Text.Equals(user.Email) && txtPass.Text.Equals(user.Password))
                    {
                        frmMain m = new frmMain();
                        m.UserRole = user.CustomerName;
                        m.UserID = user.CustomerId;
                        m.Email = user.Email;
                        m.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Email or Password incorrect !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Email or Password incorrect !!!");
                }
            }
        }
    }
}
