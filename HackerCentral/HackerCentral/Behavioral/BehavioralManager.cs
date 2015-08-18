using System.Linq;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Behavioral {
   public class BehavioralManager : Manager{
      private List<BehavioralTracker> trackers;
      private List<BehavioralGoal> goals;
      private List<BehavioralLimit> limits;
      private BehavioralIO io;
      private int nextTrackerID;
      private int nextGoalID;
      private int nextLimitID;

      public BehavioralManager() {
         trackers = new List<BehavioralTracker>();
         goals = new List<BehavioralGoal>();
         limits = new List<BehavioralLimit>();
      }

      public void initialize() {
         // Read in IDs
         trackers = io.readTrackersFromFiles();
         goals = io.readGoalsFromFiles();
         limits = io.readLimitsFromFiles();
         match();
      }

      public void match() {
         foreach (BehavioralTracker tracker in trackers) {
            tracker.setGoal(goals.SingleOrDefault(x => x.getGoalID() == tracker.getGoalID()));
            tracker.setLimit(limits.SingleOrDefault(x => x.getLimitID() == tracker.getLimitID()));
         }
         foreach (BehavioralGoal goal in goals) {
            goal.setTrackers(trackers.Where(x => goal.getTrackerIDs.Contains(x.getTrackerID())));
            goal.setLimits(limits.Where(x => goal.getLimitIDs.Contains(x.getLimitID())));
         }
         foreach (BehavioralLimit limit in limits)
            limit.setTracker(trackers.SingleOrDefault(x => x.getTrackerID() == limit.getTrackerID()));
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<BehavioralTracker> getTrackers() { return trackers; }
      public List<BehavioralGoal> getGoals() { return goals; }
      public List<BehavioralLimit> getLimits() { return limits; }
      public IO getIO() { return io; }
      public int getNextTrackerID() { return nextTrackerID; }
      public int getNextGoalID() { return nextGoalID; }
      public int getNextLimitID() { return nextLimitID; }

      // setter methods
      public void setTrackers(List<BehavioralTracker> param) { trackers = param; }
      public void setGoals(List<BehavioralGoal> param) { goals = param; }
      public void setLimits(List<BehavioralLimit> param) { limits = param; }
      public void setIO(BehavioralIO param) { io = param; }
      public void setNextTrackerID(int param) { nextTrackerID = param; }
      public void setNextGoalID(int param) { nextGoalID = param; }
      public void setNextLimitID(int param) { nextLimitID = param; }
   }
}
