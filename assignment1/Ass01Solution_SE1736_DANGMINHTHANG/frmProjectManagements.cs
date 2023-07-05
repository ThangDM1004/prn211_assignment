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
    public partial class frmProjectManagements : Form
    {
        IProjectRepository projectRepository = new ProjectRepository();
        BindingSource source;
        public frmProjectManagements()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProjectDetails frmProjectDetails = new frmProjectDetails
            {
                Text = "Add Project",
                InsertOrUpdate = false,
                ProjectRepository = projectRepository
            };
            if (frmProjectDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProjectList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var project = GetProjectObject();
                projectRepository.Remote(project.ProjectID);
                LoadProjectList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a project");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProjectList();
        }

        private void txtClose_Click(object sender, EventArgs e) => Close();


        private void frmProjectManagements_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvProjectList.CellDoubleClick += dgvProjectList_CellDoubleClick;
        }

        private void dgvProjectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProjectDetails frmProjectDetails = new frmProjectDetails
            {
                Text = "Update Project",
                InsertOrUpdate = true,
                ProjectInfo = GetProjectObject(),
                ProjectRepository = projectRepository
            };
            if (frmProjectDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProjectList();

            }
        }
        private void ClearText()
        {
            txtProID.Text = string.Empty;
            txtProName.Text = string.Empty;
            txtProAdd.Text = string.Empty;
            txtProCity.Text = string.Empty;
            txtProDes.Text = string.Empty;
            txtProSpo.Text = string.Empty;
            txtStartDate.Text = string.Empty;
            txtEndDate.Text = string.Empty;
        }
        private ProjectObject GetProjectObject()
        {
            ProjectObject projectObject = null;
            try
            {
                projectObject = new ProjectObject
                {
                    ProjectID = int.Parse(txtProID.Text),
                    ProjectName = txtProName.Text,
                    ProjectAddress = txtProAdd.Text,
                    ProjectCity = txtProCity.Text,
                    ProjectDescription = txtProDes.Text,
                    ProjectSponsor = txtProSpo.Text,
                    EstimatedStartDate = txtStartDate.Text,
                    EstimatedEndDate = txtEndDate.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Project");
            }
            return projectObject;
        }
        public void LoadProjectList()
        {
            var projects = projectRepository.GetProject();
            try
            {
                source = new BindingSource();
                source.DataSource = projects;

                txtProID.DataBindings.Clear();
                txtProName.DataBindings.Clear();
                txtProSpo.DataBindings.Clear();
                txtProDes.DataBindings.Clear();
                txtStartDate.DataBindings.Clear();
                txtEndDate.DataBindings.Clear();
                txtProAdd.DataBindings.Clear();
                txtProCity.DataBindings.Clear();

                txtProID.DataBindings.Add("Text", source, "ProjectID");
                txtProName.DataBindings.Add("Text", source, "ProjectName");
                txtProSpo.DataBindings.Add("Text", source, "ProjectSponsor");
                txtProDes.DataBindings.Add("Text", source, "ProjectDescription");
                txtStartDate.DataBindings.Add("Text", source, "EstimatedStartDate");
                txtEndDate.DataBindings.Add("Text", source, "EstimatedEndDate");
                txtProAdd.DataBindings.Add("Text", source, "ProjectAddress");
                txtProCity.DataBindings.Add("Text", source, "ProjectCity");

                dgvProjectList.DataSource = null;
                dgvProjectList.DataSource = source;
                if (projects.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load project list");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(txtSearch.Text, out _);
            if (isNumeric)
            {
                var projects = projectRepository.GetProjectObjectByID(int.Parse(txtSearch.Text));
                if (projects == null)
                {
                    MessageBox.Show("ProjectID does not exist");
                }
                else
                {


                    try
                    {
                        source = new BindingSource();
                        source.DataSource = projects;

                        txtProID.DataBindings.Clear();
                        txtProName.DataBindings.Clear();
                        txtProSpo.DataBindings.Clear();
                        txtProDes.DataBindings.Clear();
                        txtStartDate.DataBindings.Clear();
                        txtEndDate.DataBindings.Clear();
                        txtProAdd.DataBindings.Clear();
                        txtProCity.DataBindings.Clear();

                        txtProID.DataBindings.Add("Text", source, "ProjectID");
                        txtProName.DataBindings.Add("Text", source, "ProjectName");
                        txtProSpo.DataBindings.Add("Text", source, "ProjectSponsor");
                        txtProDes.DataBindings.Add("Text", source, "ProjectDescription");
                        txtStartDate.DataBindings.Add("Text", source, "EstimatedStartDate");
                        txtEndDate.DataBindings.Add("Text", source, "EstimatedEndDate");
                        txtProAdd.DataBindings.Add("Text", source, "ProjectAddress");
                        txtProCity.DataBindings.Add("Text", source, "ProjectCity");

                        dgvProjectList.DataSource = null;
                        dgvProjectList.DataSource = source;
                        if (projects.ProjectID == 0)
                        {
                            ClearText();
                            btnDelete.Enabled = false;
                        }
                        else
                        {
                            btnDelete.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Load project list");
                    }
                }
            }
            else
            {
                var projects = projectRepository.GetProjectObjectByName(txtSearch.Text);
                if (projects == null)
                {
                    MessageBox.Show("ProjectName does not exist");
                }
                else
                {
                    try
                    {
                        source = new BindingSource();
                        source.DataSource = projects;

                        txtProID.DataBindings.Clear();
                        txtProName.DataBindings.Clear();
                        txtProSpo.DataBindings.Clear();
                        txtProDes.DataBindings.Clear();
                        txtStartDate.DataBindings.Clear();
                        txtEndDate.DataBindings.Clear();
                        txtProAdd.DataBindings.Clear();
                        txtProCity.DataBindings.Clear();

                        txtProID.DataBindings.Add("Text", source, "ProjectID");
                        txtProName.DataBindings.Add("Text", source, "ProjectName");
                        txtProSpo.DataBindings.Add("Text", source, "ProjectSponsor");
                        txtProDes.DataBindings.Add("Text", source, "ProjectDescription");
                        txtStartDate.DataBindings.Add("Text", source, "EstimatedStartDate");
                        txtEndDate.DataBindings.Add("Text", source, "EstimatedEndDate");
                        txtProAdd.DataBindings.Add("Text", source, "ProjectAddress");
                        txtProCity.DataBindings.Add("Text", source, "ProjectCity");

                        dgvProjectList.DataSource = null;
                        dgvProjectList.DataSource = source;
                        if (projects.ProjectID == 0)
                        {
                            ClearText();
                            btnDelete.Enabled = false;
                        }
                        else
                        {
                            btnDelete.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Load project list");
                    }
                }
            }
        }

        private void cbProductCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProjectObject> projects = projectRepository.GetProjectByCity(cbProductCity.Text);
            if (projects == null)
            {
                MessageBox.Show($"There are no projects in {cbProductCity.Text}");
            }
            else
            {
                try
                {
                    source = new BindingSource();
                    source.DataSource = projects;

                    txtProID.DataBindings.Clear();
                    txtProName.DataBindings.Clear();
                    txtProSpo.DataBindings.Clear();
                    txtProDes.DataBindings.Clear();
                    txtStartDate.DataBindings.Clear();
                    txtEndDate.DataBindings.Clear();
                    txtProAdd.DataBindings.Clear();
                    txtProCity.DataBindings.Clear();

                    txtProID.DataBindings.Add("Text", source, "ProjectID");
                    txtProName.DataBindings.Add("Text", source, "ProjectName");
                    txtProSpo.DataBindings.Add("Text", source, "ProjectSponsor");
                    txtProDes.DataBindings.Add("Text", source, "ProjectDescription");
                    txtStartDate.DataBindings.Add("Text", source, "EstimatedStartDate");
                    txtEndDate.DataBindings.Add("Text", source, "EstimatedEndDate");
                    txtProAdd.DataBindings.Add("Text", source, "ProjectAddress");
                    txtProCity.DataBindings.Add("Text", source, "ProjectCity");

                    dgvProjectList.DataSource = null;
                    dgvProjectList.DataSource = source;
                    if (projects.Count == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load project list");
                }
            }
        }

       
    }
}
