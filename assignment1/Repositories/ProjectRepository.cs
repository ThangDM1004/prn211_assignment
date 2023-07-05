using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public ProjectObject GetProjectObjectByID(int projectID) => ProjectDAO.Instance.GetProjectByID(projectID);

        public ProjectObject GetProjectObjectByName(string projectName) => ProjectDAO.Instance.GetProjectByName(projectName);

        public List<ProjectObject> GetProjectByCity(string projectCity) => ProjectDAO.Instance.GetProjectByCity(projectCity);
        public IEnumerable<ProjectObject> GetProject() => ProjectDAO.Instance.GetProjectsList;

        public void InsertProject(ProjectObject projectObject) => ProjectDAO.Instance.AddNew(projectObject);

        public void Remote(int ProjectID) => ProjectDAO.Instance.Remote(ProjectID);

        public void Update(ProjectObject projectObject) => ProjectDAO.Instance.Update(projectObject);
    }
}
