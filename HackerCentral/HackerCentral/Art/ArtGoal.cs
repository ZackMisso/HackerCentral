using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Art {
   public class ArtGoal : Goal {
      private List<ArtTask> tasks;
      private int numberOfTasks;
      private int finishedTasks;
      private bool allTasks;

      public ArtGoal() {
         tasks = new List<ArtTask>();
      }

      public override void updateGoal(object obj) {
         throw new System.NotImplementedException();
      }

      // getter methods
      public List<ArtTask> getTasks() { return tasks; }
      public int getNumberOfTasks() { return numberOfTasks; }
      public int getFinishedTasks() { return finishedTasks; }
      public bool getAllTasks() { return allTasks; }

      // setter methods
      public void setTasks(List<ArtTask> param) { tasks = param; }
      public void setNumberOfTasks(int param) { numberOfTasks = param; }
      public void setFinishedTasks(int param) { finishedTasks = param; }
      public void setAllTasks(bool param) { allTasks = param; }
   }
}
