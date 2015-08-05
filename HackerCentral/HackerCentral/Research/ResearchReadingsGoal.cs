using System.Text;
using System.Collections.Generic;

namespace HackerCentral.Research {
   public class ResearchReadingsGoal : ResearchGoal{
      private List<ResearchReading> toRead;
      private List<int> toReadIDs;
      private int totalPages;
      private int pagesRead;
      private bool goalBasedOnReadings;
      private bool goalBasedOnPages;
      private bool allReadings;

      public ResearchReadingsGoal() {
         toRead = new List<ResearchReading>();
         toReadIDs = new List<int>();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("ResearchReadingsGoal" + "^");
         sb.Append(getGoalID().ToString() + "^");
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
         sb.Append(toRead.Count + "^");
         foreach (ResearchReading reading in toRead)
            sb.Append(reading.getReadingID() + "^");
         sb.Append(totalPages.ToString() + "^");
         sb.Append(pagesRead.ToString() + "^");
         sb.Append(goalBasedOnReadings + "^");
         sb.Append(goalBasedOnPages + "^");
         sb.Append(allReadings + "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public List<ResearchReading> getToRead() { return toRead; }
      public List<int> getToReadIDs() { return toReadIDs; }
      public int getTotalPages() { return totalPages; }
      public int getPagesRead() { return pagesRead; }
      public bool getGoalBasedOnReadings() { return goalBasedOnReadings; }
      public bool getGoalBasedOnPages() { return goalBasedOnPages; }
      public bool getAllReadings() { return allReadings; }

      // setter methods
      public void setToRead(List<ResearchReading> param) { toRead = param; }
      public void setToReadIDs(List<int> param) { toReadIDs = param; }
      public void setTotalPages(int param) { totalPages = param; }
      public void setPagesRead(int param) { pagesRead = param; }
      public void setGoalBasedOnReadings(bool param) { goalBasedOnReadings = param; }
      public void setGoalBasedOnPages(bool param) { goalBasedOnPages = param; }
      public void setAllReadings(bool param) { allReadings = param; }
   }
}
