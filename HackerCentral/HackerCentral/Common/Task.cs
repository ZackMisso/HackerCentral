using HackerCentral.Common.Enum;

namespace HackerCentral.Common {
   public class Task {
      private string description;
      private int taskID;
      private int effort;
      private TaskStatusEnum status;

      public Task() {
         // to be implemented
      }

      // getter methods
      public string getDescription() { return description; }
      public int getTaskID() { return taskID; }
      public int getEffort() { return effort; }
      public TaskStatusEnum getStatus() { return status; }

      // setter methods
      public void setDescription(string param) { description = param; }
      public void setTaskID(int param) { taskID = param; }
      public void setEffort(int param) { effort = param; }
      public void setStatus(TaskStatusEnum param) { status = param; }
   }
}
