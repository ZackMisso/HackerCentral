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
         if (!Directory.Exists(getLimitsUrl();)
            Directory.CreateDirectory(getLimitsUrl());
         if (!Directory.Exists(getGoalsUrl())
            Directory.CreateDirectory(getGoalsUrl());
         if (!Directory.Exists(getTrackerUrl())
            Directory.CreateDirectory(getTrackerUrl());
         if (!Directory.Exists(getHistoryUrl())
            Directory.CreateDirectory(getHistoryUrl());
         if (!Directory.Exists(getLimitHistoryUrl()))
            Directory.CreateDirectory(getLimitHistoryUrl());
         if (!Directory.Exists(getGoalHistoryUrl())
            Directory.CreateDirectory(getGoalHistoryUrl());
         if (!Directory.Exists(getTrackerHistoryUrl())
            Directory.CreateDirectory(getTrackerHistoryUrl());
      }

      private string getLimitsUrl() { return behavioralUrl + "\\Limits"; }
      private string getGoalsUrl() { return behavioralUrl + "\\Goals"; }
      private string getTrackerUrl() { return trackerUrl + "\\Trackers"; }
      private string getHistoryUrl() { return behavioralUrl + "\\History"; }
      private string getLimitHistory() { return getHistoryUrl() + "\\Limits"; }
      private string getGoalHistory() { return getHistoryUrl() + "\\Goals"; }
      private string getTrackerHistory() { return getHistoryUrl() + "\\Trackers"; }

      #region Limits

      public List<BehavioralLimit> readLimitsFromFiles() {
         var list = new List<BehavioralLimit>();
         // to be implemented
         return list;
      }

      public void writeLimitsToFiles(List<BehavioralLimit> list) {
         foreach (BehavioralLimit limit in list) {
            var filePath = getLimitsUrl() + limit.getTracker().getName()+ "Limit" + ".txt";
            File.WriteAllText(filePath, limit.ToString());
         }
      }

      public List<BehavioralLimit> readLimitsFromHistory() {
         var list = new List<BehavioralLimit>();
         // to be implemented
         return list;
      }

      public void writeLimitsToHistory(List<BehavioralLimit> list) {
         foreach (BehavioralLimit limit in list) {
            var filePath = getLimitHistoryUrl() + limit.getTracker().getName() + "Limit" + ".txt";
            using (StreamWriter sw = File.AppendText(filePath))
               sw.WriteLine(limit.ToString());
         }
      }

      public void writeLimitToFile(BehavioralLimit limit) {
         var filePath = getLimitsUrl() + limit.getTracker().getName() + "Limit" + ".txt";
         File.WriteAllText(filePath, limit.ToString());
      }

      public void writeLimitToHistory(BehavioralLimit limie) {
         var filePath = getLimitHistoryUrl() + limit.getTracker().getName() + "Limit" + ".txt";
         using (StreamWriter sw = File.AppendText(filePath))
            sw.WriteLine(limit.ToString());
      }

      #endregion

      #region Goals

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

      public void writeGoalToFile(BehavioralGoal goal) {
         // to be implemented
      }

      public void writeGoalToHistory(BehavioralGoal goal) {
         // to be implemented
      }

      #endregion

      #region Trackers

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

      public void writeTrackerToFile(BehavioralTracker tracker) {
         // to be implemented
      }

      public void writeTrackerToHistory(BehavioralTracker tracker) {
         // to be implemented
      }

      #endregion

      // setter method
      public void setBehavioralUrl(string param) { behavioralUrl = param; }
   }
}
