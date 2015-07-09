using System.Text;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsTask : Task{
      private CodingProject project;
      //private string type;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public CodingProject getProject() { return project; }
      //public string getType() { return type; }

      // setter methods
      public void setProject(CodingProject param) { project = param; }
      //public void setType(string param) { type = param; }
   }
}
