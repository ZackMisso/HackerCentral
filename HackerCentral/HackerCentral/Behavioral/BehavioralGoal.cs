using System;
using System.Text;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Behavioral {
   public class BehavioralGoal : Goal {
      private List<BehavioralTracker> trackers;
      private List<int> trackerIDs;
      private List<BehavioralLimit> limits;
      private List<int> limitIDs;
      private DateTime startDate;
      private bool moreNeeded;
      private bool monthly;
      private bool dailey;
      private bool weekly;

      public BehavioralGoal() {
         trackers = new List<BehavioralTracker>();
         trackerIDs = new List<int>();
         limits = new List<BehavioralLimit>();
         limitIDs = new List<int>();
      }

      public override void updateGoal(object obj) {
         throw new System.NotImplementedException();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public List<BehavioralTracker> getTrackers() { return trackers; }
      public List<int> getTrackerIDs() { return trackerIDs; }
      public List<BehavioralLimit> getLimits() { return limits; }
      public List<int> getLimitIDs() { return limitIDs; }
      public DateTime getStartTime() { return startTime; }
      public bool getMoreNeeded() { return moreNeeded; }
      public bool getMonthly() { return monthly; }
      public bool getDailey() { return dailey; }
      public bool getWeekly() { return weekly; }

      // setter methods
      public void setTrackers(List<BehavioralTracker> param) { trackers = param; }
      public void setTrackerIDs(List<int> param) { trackerIDs = param; }
      public void setLimits(List<BehavioralLimit> param) { limits = param; }
      public void setLimitIDs(List<int> param) { limitIDs = param; }
      public void setStartTime(DateTime param) { startTime = param; }
      public void setMoreNeeded(bool param) { moreNeeded = param; }
      public void setMonthly(bool param) { monthly = param; }
      public void setDailey(bool param) { dailey = param; }
      public void setWeekly(bool param) { weekly = param; }
   }
}
