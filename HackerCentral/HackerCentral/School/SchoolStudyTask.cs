using System;
using System.Text;

namespace HackerCentral.School {
   public class SchoolStudyTask : SchoolTask{
      private SchoolClass clas;
      private DateTime startDate;
      private int clasID;
      private int hours;
      private int inDays;
      private bool weekly;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("SchoolStudyTask" + "^");
         sb.Append(clasID.ToString() + "^");
         sb.Append(hours.ToString() + "^");
         sb.Append(inDays.ToString() + "^");
         sb.Append(startDate.ToString("MM\dd\yyyy") + "^");
         sb.Append(weekly + "^");
         sb.Append(getName() + "^");
         sb.Append(getTaskID().ToString() + "^");
         sb.Append(getEffort().ToString() + "^");
         if (getStatus() == TaskStatusEnum.ToDo)
            sb.Append("To Do" + "^");
         if (getStatus() == TaskStatusEnum.InProgress)
            sb.Append("In Progress" + "^");
         if (getStatus() == TaskStatusEnum.Done)
            sb.Append("Done" + "^");
         if (getStatus() == TaskStatusEnum.Canceled)
            sb.Append("Canceled" + "^");
         if (getStatus() == TaskStatusEnum.Failed)
            sb.Append("Failed" + "^");
         sb.Append(getDescription() "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public SchoolClass getClas() { return clas; }
      public DateTime getStartDate() { return startDate; }
      public int getClasID() { return clasID; }
      public int getHours() { return hours; }
      public int getInDays() { return inDays; }
      public bool getWeekly() { return weekly; }

      // setter methods
      public void setClas(SchoolClass param) { clas = param; }
      public void setStartDate(DateTime param) { startDate = param; }
      public void setClasID(int param) { clasID = param; }
      public void setHours(int param) { hours = param; }
      public void setInDays(int param) { inDays = param; }
      public void setWeekly(bool param) { weekly = param; }
   }
}
