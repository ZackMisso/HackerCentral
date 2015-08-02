using System.Text;

namespace HackerCentral.Behavioral {
   public class BehavioralLimit {
      private BehavioralTracker tracker;
      private int trackerID;
      private int limit;
      private int limitID;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(limitID.ToString() + "^");
         sb.Append(limit.ToString() + "^");
         sb.Append(trackerID.ToString() + "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public BehavioralTracker getTracker() { return tracker; }
      public int getTrackerID() { return trackerID; }
      public int getLimit() { return limit; }
      public int getLimitID() { return limitID; }

      // setter methods
      public void setTracker(BehavioralTracker param) { tracker = param; }
      public void setTrackerID(int param) { trackerID = param; }
      public void setLimit(int param) { limit = param; }
      public void setLimitID(int param) { limitID = param; }
   }
}
