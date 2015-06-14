using System.Collections.Generic;

namespace HackerCentral.Common{
   public class TaskGoal : Goal{
      private List<Task> tasks;

      public TaskGoal()
         : base() {
         // to be implemnted
      }

      public void updateGoal(object obj) {
         // to be implmented
      }

      // getter methods
      public List<Task> getTasks() { return tasks; }

      // setter methods
      public void setTasks(List<Task> param) { tasks = param; }
   }
}
