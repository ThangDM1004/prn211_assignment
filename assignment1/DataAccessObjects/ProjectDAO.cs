using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{

    public class ProjectDAO
    {
        private static List<ProjectObject> ProjectList = new List<ProjectObject>()
       {
           new ProjectObject{ ProjectID = 1,ProjectName="SWP391", 
               ProjectAddress="FPT HCM", ProjectCity="HCM",
               ProjectDescription="Clinic", ProjectSponsor="FPT", 
               EstimatedStartDate = "10/06/2023",
               EstimatedEndDate = "13/06/2023"  },
           new ProjectObject{ ProjectID = 2,ProjectName = "PRN211",
               ProjectAddress="FPT HCM", ProjectCity="HCM",
               ProjectDescription ="System", ProjectSponsor="FPT",
               EstimatedStartDate = "10/06/2023",
               EstimatedEndDate = "13/06/2023"  }
        };

        private static ProjectDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProjectDAO() { }
        public static ProjectDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProjectDAO();
                    }
                    return instance;
                }
            }
        }
        public List<ProjectObject> GetProjectsList => ProjectList;
        public ProjectObject GetProjectByID(int projectID)
        {
            ProjectObject project = ProjectList.FirstOrDefault(pro => pro.ProjectID == projectID);
            return project;
        }

        public void AddNew(ProjectObject projectObject)
        {
            ProjectObject pro = GetProjectByID(projectObject.ProjectID);
            if (pro == null)
            {
                ProjectList.Add(projectObject);
            }
            else
            {
                throw new Exception("Project is already exists");
            }
        }

        public void Update(ProjectObject project)
        {
            ProjectObject p = GetProjectByID(project.ProjectID);
            if (p != null)
            {
                var index = ProjectList.IndexOf(p);
                ProjectList[index] = project;
            }
            else
            {
                throw new Exception("Project does not already exists");
            }
        }

        public void Remote(int ProjectID)
        {
            ProjectObject p = GetProjectByID(ProjectID);
            if (p != null)
            {
                ProjectList.Remove(p);
            }
            else
            {
                throw new Exception("Project does not already exists");
            }
        }
        public ProjectObject GetProjectByName(String projectName)
        {
            ProjectObject project = ProjectList.FirstOrDefault(pro => pro.ProjectName == projectName);
            return project;
        }

        public List<ProjectObject> GetProjectByCity(string projectCity)
        {
            var list = new List<ProjectObject>();
            foreach (var item in ProjectList)
            {
                if (item.ProjectCity.Equals(projectCity)) { list.Add(item); }
            }
            return list;
        }
    }
}

