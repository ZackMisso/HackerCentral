using System.Text;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public abstract class CodingProjectsGoal : Goal{
      private CodingProject project;
      private int projectID;
      
      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public CodingProject getProject() { return project; }
      public int getProjectID() { return projectID; }

      // setter methods
      public void setProject(CodingProject param) { project = param; }
      public void setProjectID(int param) { projectID = param; }
   }
}
