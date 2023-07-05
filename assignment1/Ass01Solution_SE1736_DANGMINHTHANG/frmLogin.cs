using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration.Json;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Ass01Solution_SE1736_DANGMINHTHANG
{
    public partial class frmLogin : Form
    {
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
            var password = builder["AdminAccount:AdminPass"];
            if (txtEmail.Text.Equals(email) && txtPass.Text.Equals(password))
            {
                frmProjectManagements f = new frmProjectManagements();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Account invalid");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
