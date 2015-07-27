using System.Text;
using HackerCentral.Common;
using HackerCentral.Common.Enum;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsTask : Task{
      private CodingProject project;
      private int projectID;
      //private string type;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(getName());
         sb.Append("^" + getTaskID().ToString());
         sb.Append("^" + getEffort().ToString());
         TaskStatusEnum stat = getStatus();
         if(stat == TaskStatusEnum.InProgress)
            sb.Append("^InProgress");
         if(stat == TaskStatusEnum.ToDo)
            sb.Append("^ToDo");
         if(stat == TaskStatusEnum.Failed)
            sb.Append("^Failed");
         if(stat == TaskStatusEnum.Done)
            sb.Append("^Done");
         if(stat == TaskStatusEnum.Canceled)
            sb.Append("^Canceled");
         sb.Append("^" + project.getProjectID());
         sb.Append("^" + getDescription());
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public CodingProject getProject() { return project; }
      public int getProjectID() { return projectID; }
      //public string getType() { return type; }

      // setter methods
      public void setProject(CodingProject param) { project = param; }
      public void setProjectID(int param) { projectID = param; }
      //public void setType(string param) { type = param; }
   }
}
