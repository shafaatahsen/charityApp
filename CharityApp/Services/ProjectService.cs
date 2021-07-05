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
            return projects.FirstOrDefault(project => project.Id == id);
        }

        public Project Create(Project proj)
        {
            proj.Id = Count++;
            projects.Add(proj);
            return proj;
        }
        
        public void Update(int id, Project proj)
        {
            Project found = projects.FirstOrDefault(p => proj.Id == id);
            found.Name = proj.Name;
            found.TargetAmount = proj.TargetAmount;
            found.CurrentAmount = proj.CurrentAmount;
            found.Finished = proj.Finished;
        }
        
        
    }
}