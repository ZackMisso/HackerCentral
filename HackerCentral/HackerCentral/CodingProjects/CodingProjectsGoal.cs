using System.Text;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public abstract class CodingProjectsGoal : Goal{
      private CodingProject project;
      
      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public CodingProject getProject() { return project; }

      // setter methods
      public void setProject(CodingProject param) { project = param; }
   }
}
