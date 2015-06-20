using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public abstract class CodingProjectsGoal : Goal{
      private CodingProject project;

      public CodingProjectsGoal() {
         project = null;
      }      

      // getter methods
      public CodingProject getProject() { return project; }

      // setter methods
      public void setProject(CodingProject param) { project = param; }
   }
}
