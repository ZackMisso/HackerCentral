using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Behavioral {
   public class BehavioralIO : IO{
      private BehavioralManager manager;
      private string behavioralUrl;

      public BehavioralIO(BehavioralManager param,string url) {
         manager = param;
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

      public void writeLimitsToFiles(List<BehavioralLimit> list) {
         // to be implemented
      }

      public List<BehavioralLimit> readLimitsFromHistory() {
         var list = new List<BehavioralLimit>();
         // to be implemented
         return list;
      }

      public void writeLimitsToHistory(List<BehavioralLimit> list) {
         // to be implemented
      }

      public List<BehavioralGoal> readGoalsFromFiles() {
         var list = new List<BehavioralGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToFiles(List<BehavioralGoal> list) {
         // to be implemented
      }

      public List<BehavioralGoal> readGoalsFromHistory() {
         var list = new List<BehavioralGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<BehavioralGoal> list) {
         // to be implemented
      }

      public List<BehavioralTracker> readTrackersFromFiles() {
         var list = new List<BehavioralTracker>();
         // to be implemented
         return list;
      }

      public void writeTrackersToFiles(List<BehavioralTracker> list) {
         // to be implemented
      }

      public List<BehavioralTracker> readTrackersFromHistory() {
         var list = new List<BehavioralTracker>();
         // to be implemented
         return list;
      }

      public void writeTrackersToHistory(List<BehavioralTracker> list) {
         // to be implemented
      }

      // setter method
      public void setBehavioralUrl(string param) { behavioralUrl = param; }
   }
}
