using System;
using System.Collections.Generic;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsMasterGoal : CodingProjectsGoal{
      private List<CodingProjectsTask> tasksToDo;
      private DateTime dueDate;
      private int numberOfTasksCompleted;
      private int totalNumberOfLines;
      private int goal;
      private bool lineGoal;
      private bool certainTasksGoal;
      private bool numberOfTasksGoal;

      public CodingProjectsMasterGoal() : base() {
         tasksToDo = new List<CodingProjectsTask>();
         numberOfTasksCompleted = 0;
         totalNumberOfLines = 0;
         goal = 0;
         lineGoal = false;
         certainTasksGoal = false;
         numberOfTasksGoal = false;
      }

      public override void updateGoal(object obj) {
         var project = (CodingProject)obj;
      }

      // getter methods
      public List<CodingProjectsTask> getTasksToDo() { return tasksToDo; }
      public DateTime getDueDate() { return dueDate; }
      public int getNumberOfTasksCompleted() { return numberOfTasksCompleted; }
      public int getTotalNumberOfLines() { return totalNumberOfLines; }
      public int getGoal() { return goal; }
      public bool getLineGoal() { return lineGoal; }
      public bool getCertainTasksGoal() { return certainTasksGoal; }
      public bool getNumberOfTasksGoal() { return numberOfTasksGoal; }

      // setter methods
      public void setTasksToDo(List<CodingProjectsTask> param) { tasksToDo = param; }
      public void setDueDate(DateTime param) { dueDate = param; }
      public void setNumberOfTasksCompleted(int param) { numberOfTasksCompleted = param; }
      public void setTotalNumberOfLines(int param) { totalNumberOfLines = param; }
      public void setGoal(int param) { goal = param; }
      public void setLineGoal(bool param) { lineGoal = param; }
      public void setCertainTasksGoal(bool param) { certainTasksGoal = param; }
      public void setNumberOfTasksGoal(bool param) { numberOfTasksGoal = param; }
   }
}
