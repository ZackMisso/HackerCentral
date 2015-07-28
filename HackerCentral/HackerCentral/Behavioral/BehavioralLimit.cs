using System.Text;

namespace HackerCentral.Behavioral {
   public class BehavioralLimit {
      private BehavioralTracker tracker;
      private int trackerID;
      private int limit;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public BehavioralTracker getTracker() { return tracker; }
      public int getTrackerID() { return trackerID; }
      public int getLimit() { return limit; }

      // setter methods
      public void setTracker(BehavioralTracker param) { tracker = param; }
      public void setTrackerID(int param) { trackerID = param; }
      public void setLimit(int param) { limit = param; }
   }
}
