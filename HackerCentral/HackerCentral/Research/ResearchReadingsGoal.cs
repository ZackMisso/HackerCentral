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
         // to be implemented
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
