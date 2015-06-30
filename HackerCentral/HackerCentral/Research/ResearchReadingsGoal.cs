using System.Collections.Generic;

namespace HackerCentral.Research {
   public class ResearchReadingsGoal : ResearchGoal{
      private List<ResearchReading> toRead;
      private int totalPages;
      private int pagesRead;
      private bool goalBasedOnReadings;
      private bool goalBasedOnPages;
      private bool allReadings;

      // getter methods
      public List<ResearchReading> getToRead() { return toRead; }
      public int getTotalPages() { return totalPages; }
      public int getPagesRead() { return pagesRead; }
      public bool getGoalBasedOnReadings() { return goalBasedOnReadings; }
      public bool getGoalBasedOnPages() { return goalBasedOnPages; }
      public bool getAllReadings() { return allReadings; }

      // setter methods
      public void setToRead(List<ResearchReading> param) { toRead = param; }
      public void setTotalPages(int param) { totalPages = param; }
      public void setPagesRead(int param) { pagesRead = param; }
      public void setGoalBasedOnReadings(bool param) { goalBasedOnReadings = param; }
      public void setGoalBasedOnPages(bool param) { goalBasedOnPages = param; }
      public void setAllReadings(bool param) { allReadings = param; }
   }
}
