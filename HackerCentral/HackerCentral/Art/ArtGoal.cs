using System.Text;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Art {
   public class ArtGoal : Goal {
      private List<ArtTask> tasks;
      private List<int> taskIDs;
      private int numberOfTasks;
      private int finishedTasks;
      private bool allTasks;

      public ArtGoal() {
         tasks = new List<ArtTask>();
         taskIDs = new List<int>();
      }

      public override void updateGoal(object obj) {
         throw new System.NotImplementedException();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public List<ArtTask> getTasks() { return tasks; }
      public List<int> getTaskIDs() { return taskIDs; }
      public int getNumberOfTasks() { return numberOfTasks; }
      public int getFinishedTasks() { return finishedTasks; }
      public bool getAllTasks() { return allTasks; }

      // setter methods
      public void setTasks(List<ArtTask> param) { tasks = param; }
      public void setTaskIDs(List<int> param) { taskIDs = param; }
      public void setNumberOfTasks(int param) { numberOfTasks = param; }
      public void setFinishedTasks(int param) { finishedTasks = param; }
      public void setAllTasks(bool param) { allTasks = param; }
   }
}
