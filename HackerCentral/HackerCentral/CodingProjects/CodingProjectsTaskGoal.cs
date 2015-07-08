using System.Text;
using System.Collections.Generic;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsTaskGoal : CodingProjectsGoal{
      private List<CodingProjectsTask> tasks;

      public CodingProjectsTaskGoal()
         : base() {
            tasks = new List<CodingProjectsTask>();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      public override void updateGoal(object obj) {
         var project = (CodingProject)obj;
      }

      // getter methods
      public List<CodingProjectsTask> getTasks() { return tasks; }

      // setter methods
      public void setTasks(List<CodingProjectsTask> param) { tasks = param; }
   }
}
