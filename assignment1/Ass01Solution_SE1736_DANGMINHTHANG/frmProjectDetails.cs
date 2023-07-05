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

namespace Ass01Solution_SE1736_DANGMINHTHANG
{
    public partial class frmProjectDetails : Form
    {
        public frmProjectDetails()
        {
            InitializeComponent();
        }
        public IProjectRepository ProjectRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProjectObject ProjectInfo { get; set; }
        private void txtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                var project = new ProjectObject
                {
                    ProjectID = int.Parse(txtID.Text),
                    ProjectName = txtName.Text,
                    ProjectAddress = txtAddress.Text,
                    ProjectCity = txtCity.Text,
                    ProjectDescription = txtDescription.Text,
                    ProjectSponsor = txtSponsor.Text,
                    EstimatedStartDate = StartDate.Text,
                    EstimatedEndDate = EndDate.Text
                };

                if (InsertOrUpdate == false)
                {
                    ProjectRepository.InsertProject(project);
                    MessageBox.Show("Add Project Successfully !!!");
                }
                else
                {
                    ProjectRepository.Update(project);
                    DialogResult dg = MessageBox.Show("Update Project Successfully !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new project" : "Update a project");
            }
        }

        private void frmProjectDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtID.Text = ProjectInfo.ProjectID.ToString();
                txtName.Text = ProjectInfo.ProjectName;
                txtDescription.Text = ProjectInfo.ProjectDescription.ToString();
                txtAddress.Text = ProjectInfo.ProjectAddress.ToString();
                txtCity.Text = ProjectInfo.ProjectCity.ToString();
                txtSponsor.Text = ProjectInfo.ProjectSponsor.ToString();
                StartDate.Text = ProjectInfo.EstimatedStartDate.ToString();
                EndDate.Text = ProjectInfo.EstimatedEndDate.ToString();
            }
        }
    }
}
