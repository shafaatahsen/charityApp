using System.Collections.Generic;
using System.Linq;
using CharityApp.Models;

namespace CharityApp.Services
{
    public class ProjectService
    {
        private static List<Project> projects = new List<Project>();
        private static int Count = 1;
        
        public List<Project> GetAllProjects()
        {
            return projects;
        }

        public Project GetById(int id)
        {
            return projects.Where(project => project.id == id).FirstOrDefault();
        }

        public Project Create(Project project)
        {
            project.Id = Count++;
            projects.Add(proj);
            return proj;
        }
        
        
        
    }
}