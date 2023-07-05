using BusinessObjects;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Repositories
{
    public interface IProjectRepository
    {
        IEnumerable<ProjectObject> GetProject();
        ProjectObject GetProjectObjectByID(int projectID);

        ProjectObject GetProjectObjectByName(string projectName);

        List<ProjectObject> GetProjectByCity(string projectCity);
        void InsertProject(ProjectObject projectObject);
        void Remote(int ProjectID);
        void Update(ProjectObject projectObject);
    }
}
