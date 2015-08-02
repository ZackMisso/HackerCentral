using System.Text;
using System.Collections.Generic;
using HackerCentral.Common;
using HackerCentral.Common.Enum;

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
         sb.Append("ArtGoal" + "^");
         sb.Append(getGoalID() + "^");
         if (getStatus() == GoalStatusEnum.None)
            sb.Append("None" + "^");
         if (getStatus() == GoalStatusEnum.NotStarted)
            sb.Append("Not Started" + "^");
         if (getStatus() == GoalStatusEnum.InProgress)
            sb.Append("In Progress" + "^");
         if (getStatus() == GoalStatusEnum.Succeeded)
            sb.Append("Succeeded" + "^");
         if (getStatus() == GoalStatusEnum.Failed)
            sb.Append("Failed" + "^");
         sb.Append(getName() + "^");
         sb.Append(getPercentAccomplished().ToString() + "^");
         sb.Append(tasks.Count + "^");
         foreach (ArtTask task in tasks)
            sb.Append(task.getTaskID().ToString() + "^");
         sb.Append(numberOfTasks.ToString() + "^");
         sb.Append(finishedTasks.ToString() + "^");
         sb.Append(allTasks + "^");
         sb.Append("\n");
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
