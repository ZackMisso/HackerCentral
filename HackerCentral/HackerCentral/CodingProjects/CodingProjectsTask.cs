using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsTask : Task{
      private CodingProject project;

      public CodingProjectsTask() {
         // to be implemented
      }

      // getter methods
      public CodingProject getProject() { return project; }

      // setter methods
      public void setProject(CodingProject param) { project = param; }
   }
}
