using System;
using System.Text;

namespace HackerCentral.School {
   public class SchoolStudyTask : SchoolTask{
      private SchoolClass clas;
      private DateTime startDate;
      private int clasID;
      private int hours;
      private int inDays;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public SchoolClass getClas() { return clas; }
      public DateTime getStartDate() { return startDate; }
      public int getClasID() { return clasID; }
      public int getHours() { return hours; }
      public int getInDays() { return inDays; }

      // setter methods
      public void setClas(SchoolClass param) { clas = param; }
      public void setStartDate(DateTime param) { startDate = param; }
      public void setClasID(int param) { clasID = param; }
      public void setHours(int param) { hours = param; }
      public void setInDays(int param) { inDays = param; }
   }
}
