using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Behavioral {
   public class BehavioralIO : IO{
      private string behavioralUrl;

      public BehavioralIO(string url) {
         behavioralUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(behavioralUrl + "\\Limits"))
            Directory.CreateDirectory(behavioralUrl + "\\Limits");
         if (!Directory.Exists(behavioralUrl + "\\Goals"))
            Directory.CreateDirectory(behavioralUrl + "\\Goals");
         if (!Directory.Exists(behavioralUrl + "\\Trackers"))
            Directory.CreateDirectory(behavioralUrl + "\\Trackers");
         if (!Directory.Exists(behavioralUrl + "\\History"))
            Directory.CreateDirectory(behavioralUrl + "\\History");
         if (!Directory.Exists(behavioralUrl + "\\History\\Limits"))
            Directory.CreateDirectory(behavioralUrl + "\\History\\Limits");
         if (!Directory.Exists(behavioralUrl + "\\History\\Goals"))
            Directory.CreateDirectory(behavioralUrl + "\\History\\Goals");
         if (!Directory.Exists(behavioralUrl + "\\History\\Trackers"))
            Directory.CreateDirectory(behavioralUrl + "\\History\\Trackers");
      }

      public List<BehavioralLimit> readLimitsFromFiles() {
         var list = new List<BehavioralLimit>();
         // to be implemented
         return list;
      }

      public List<BehavioralLimit> readLimitsFromHistory() {
         var list = new List<BehavioralLimit>();
         // to be implemented
         return list;
      }

      public List<BehavioralGoal> readGoalsFromFiles() {
         var list = new List<BehavioralGoal>();
         // to be implemented
         return list;
      }

      public List<BehavioralGoal> readGoalsFromHistory() {
         var list = new List<BehavioralGoal>();
         // to be implemented
         return list;
      }

      public List<BehavioralTracker> readTrackersFromFiles() {
         var list = new List<BehavioralTracker>();
         // to be implemented
         return list;
      }

      public List<BehavioralTracker> readTrackersFromHistory() {
         var list = new List<BehavioralTracker>();
         // to be implemented
         return list;
      }

      // setter method
      public void setBehavioralUrl(string param) { behavioralUrl = param; }
   }
}
