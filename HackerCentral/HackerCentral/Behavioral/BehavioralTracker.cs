using System;

namespace HackerCentral.Behavioral {
   public class BehavioralTracker {
      private BehavioralGoal goal;
      private BehavioralLimit limit;
      private DateTime start;
      private string name;
      private int value;
      private int startingValue;
      private bool hasGoal;
      private bool hasLimit;
      private bool updatesDaily;
      private bool updatesWeekly;
      private bool updatesMonthly;

      // getter methods
      public BehavioralGoal getGoal() { return goal; }
      public BehavioralLimit getLimit() { return limit; }
      public DateTime getStart() { return start; }
      public string getName() { return name; }
      public int getValue() { return value; }
      public int getStartingValue() { return startingValue; }
      public bool getHasGoal() { return hasGoal; }
      public bool getHasLimit() { return hasLimit; }
      public bool getUpdatesDaily() { return updatesDaily; }
      public bool getUpdatesWeekly() { return updatesWeekly; }
      public bool getUpdatesMonthly() { return updatesMonthly; }

      // setter methods
      public void setGoal(BehavioralGoal param) { goal = param; }
      public void setLimit(BehavioralLimit param) { limit = param; }
      public void setStart(DateTime param) { start = param; }
      public void setName(string param) { name = param; }
      public void setValue(int param) { value = param; }
      public void setStartingValue(int param) { startingValue = param; }
      public void setHasGoal(bool param) { hasGoal = param; }
      public void setHasLimit(bool param) { hasLimit = param; }
      public void setUpdatesDaily(bool param) { updatesDaily = param; }
      public void setUpdatesWeekly(bool param) { updatesWeekly = param; }
      public void setUpdatesMonthly(bool param) { updatesMonthly = param; }
   }
}
