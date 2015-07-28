using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Behavioral {
   public class BehavioralManager : Manager{
      private List<BehavioralTracker> trackers;
      private List<BehavioralGoal> goals;
      private List<BehavioralLimit> limits;
      private BehavioralIO io;

      public BehavioralManager() {
         trackers = new List<BehavioralTracker>();
         goals = new List<BehavioralGoal>();
         limits = new List<BehavioralLimit>();
      }

      public void initialize() {
         // to be implemented
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<BehavioralTracker> getTrackers() { return trackers; }
      public List<BehavioralGoal> getGoals() { return goals; }
      public List<BehavioralLimit> getLimits() { return limits; }
      public IO getIO() { return io; }

      // setter methods
      public void setTrackers(List<BehavioralTracker> param) { trackers = param; }
      public void setGoals(List<BehavioralGoal> param) { goals = param; }
      public void setLimits(List<BehavioralLimit> param) { limits = param; }
      public void setIO(BehavioralIO param) { io = param; }
   }
}
