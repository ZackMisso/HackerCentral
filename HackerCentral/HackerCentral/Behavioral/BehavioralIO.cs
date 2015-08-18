using System;
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
         var files = Directory.GetFiles(GetLimitsUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            //var limit = new BehavioralLimit();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var limit = new BehavioralLimit();
               var contents = line.Split('^');
               limit.setLimitID(Convert.ToInt32(contents[0]));
               limit.setLimit(Convert.ToInt32(contents[1]));
               limit.setTrackerID(Convert.ToInt32(contents[2]));
               list.Add(limit);
            }
         }
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
         var files = Directory.GetFiles(GetLimitHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            //var limit = new BehavioralLimit();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var limit = new BehavioralLimit();
               var contents = line.Split('^');
               limit.setLimitID(Convert.ToInt32(contents[0]));
               limit.setLimit(Convert.ToInt32(contents[1]));
               limit.setTrackerID(Convert.ToInt32(contents[2]));
               list.Add(limit);
            }
         }
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
         var files = Directory.GetFiles(GetGoalsUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            //var goal = new BehavioralGoal();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var goal = new BehavioralGoal();
               var contents = line.Split('^');
               goal.setGoalID(Convert.ToInt32(contents[1]));
               var status = contents[2];
               if (status.Equals("None"))
                  goal.setStatus(GoalStatusEnum.None);
               else if (status.Equals("NotStarted"))
                  goal.setStatus(GoalStatusEnum.NotStarted);
               else if (status.Equals("InProgress"))
                  goal.setStatus(GoalStatusEnum.InProgress);
               else if (status.Equals("Succeeded"))
                  goal.setStatus(GoalStatusEnum.Succeeded);
               else
                  goal.setStatus(GoalStatusEnum.Failed);
               goal.setName(contents[3]);
               goal.setPercentAccomplished((float)Convert.ToDouble(contents[4]));
               var trackers = Convert.ToInt32(contents[5]);
               var itr = 6;
               for (var i = 0; i < trackers; i++)
                  goal.getTrackerIDs().Add(Convert.ToInt32(contents[itr++]));
               var limits = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < limits; i++)
                  goal.getLimitIDs().Add(Convert.ToInt32(contents[itr++]));
               // implement Data
               var date = contents[itr++];
               //goal.setStartDate();
               goal.setMoreNeeded(contents[itr++].Equals("true"));
               goal.setMonthly(contents[itr++].Equals("true"));
               goal.setDailey(contents[itr++].Equals("true"));
               goal.setWeekly(contents[itr++].Equals("true"));
               list.Add(goal);
            }
         }
         return list;
      }

      public void writeGoalsToFiles(List<BehavioralGoal> list) {
         foreach (BehavioralGoal goal in list) {
            var filePath = getGoalUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public List<BehavioralGoal> readGoalsFromHistory() {
         var list = new List<BehavioralGoal>();
         var files = Directory.GetFiles(GetGoalHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            //var goal = new BehavioralGoal();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var goal = new BehavioralGoal();
               var contents = line.Split('^');
               goal.setGoalID(Convert.ToInt32(contents[1]));
               var status = contents[2];
               if (status.Equals("None"))
                  goal.setStatus(GoalStatusEnum.None);
               else if (status.Equals("NotStarted"))
                  goal.setStatus(GoalStatusEnum.NotStarted);
               else if (status.Equals("InProgress"))
                  goal.setStatus(GoalStatusEnum.InProgress);
               else if (status.Equals("Succeeded"))
                  goal.setStatus(GoalStatusEnum.Succeeded);
               else
                  goal.setStatus(GoalStatusEnum.Failed);
               goal.setName(contents[3]);
               goal.setPercentAccomplished((float)Convert.ToDouble(contents[4]));
               var trackers = Convert.ToInt32(contents[5]);
               var itr = 6;
               for (var i = 0; i < trackers; i++)
                  goal.getTrackerIDs().Add(Convert.ToInt32(contents[itr++]));
               var limits = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < limits; i++)
                  goal.getLimitIDs().Add(Convert.ToInt32(contents[itr++]));
               // implement Data
               var date = contents[itr++];
               //goal.setStartDate();
               goal.setMoreNeeded(contents[itr++].Equals("true"));
               goal.setMonthly(contents[itr++].Equals("true"));
               goal.setDailey(contents[itr++].Equals("true"));
               goal.setWeekly(contents[itr++].Equals("true"));
               list.Add(goal);
            }
         }
         return list;
      }

      public void writeGoalsToHistory(List<BehavioralGoal> list) {
         foreach (BehavioralGoal goal in list) {
            var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public void writeGoalToFile(BehavioralGoal goal) {
         var filePath = getGoalUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      public void writeGoalToHistory(BehavioralGoal goal) {
         var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      #endregion

      #region Trackers

      public List<BehavioralTracker> readTrackersFromFiles() {
         var list = new List<BehavioralTracker>();
         var files = Directory.GetFiles(GetTrackerUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            //var tracker = new BehavioralTracker();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var tracker = new BehavioralTracker();
               var contents = line.Split('^');
               tracker.setTrackerID(Convert.ToInt32(contents[0]));
               tracker.setLimitID(Convert.ToInt32(contents[1]));
               tracker.setGoalID(Convert.ToInt32(contents[2]));
               tracker.setStartingValue(Convert.ToInt32(contents[3]));
               tracker.setValue(Convert.ToInt32(contents[4]));
               var startTime = contents[5];
               // implemented data time start
               tracker.setHasGoal(contents[6].Equals("true"));
               tracker.setHasLimit(contents[7].Equals("true"));
               tracker.setUpdatesDaily(contents[8].Equals("true"));
               tracker.setUpdatesWeekly(contents[9].Equals("true"));
               tracker.setUpdatesMonthly(contents[10].Equals("true"));
               tracker.setName(contents[11]);
               list.Add(tracker);
            }
         }
         return list;
      }

      public void writeTrackersToFiles(List<BehavioralTracker> list) {
         foreach (BehavioralTracker tracker in list) {
            var filePath = getTrackerUrl() + tracker.getName() + ".txt";
            File.WriteAllText(filePath, tracker.ToString());
         }
      }

      public List<BehavioralTracker> readTrackersFromHistory() {
         var list = new List<BehavioralTracker>();
         var files = Directory.GetFiles(GetTrackerHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            //var tracker = new BehavioralTracker();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var tracker = new BehavioralTracker();
               var contents = line.Split('^');
               tracker.setTrackerID(Convert.ToInt32(contents[0]));
               tracker.setLimitID(Convert.ToInt32(contents[1]));
               tracker.setGoalID(Convert.ToInt32(contents[2]));
               tracker.setStartingValue(Convert.ToInt32(contents[3]));
               tracker.setValue(Convert.ToInt32(contents[4]));
               var startTime = contents[5];
               // implemented data time start
               tracker.setHasGoal(contents[6].Equals("true"));
               tracker.setHasLimit(contents[7].Equals("true"));
               tracker.setUpdatesDaily(contents[8].Equals("true"));
               tracker.setUpdatesWeekly(contents[9].Equals("true"));
               tracker.setUpdatesMonthly(contents[10].Equals("true"));
               tracker.setName(contents[11]);
               list.Add(tracker);
            }
         }
         return list;
      }

      public void writeTrackersToHistory(List<BehavioralTracker> list) {
         foreach (BehavioralTracker tracker in list) {
            var filePath = getTrackerHistoryUrl() + tracker.getName() + ".txt";
            File.WriteAllText(filePath, tracker.ToString());
         }
      }

      public void writeTrackerToFile(BehavioralTracker tracker) {
         var filePath = getTrackerUrl() + tracker.getName() + ".txt";
         File.WriteAllText(filePath, tracker.ToString());
      }

      public void writeTrackerToHistory(BehavioralTracker tracker) {
         var filePath = getTrackerHistoryUrl() + tracker.getName() + ".txt";
         File.WriteAllText(filePath, tracker.ToString());
      }

      #endregion

      #region MetaData

      public void checkBehavioralSaveFile() {
         // To be implemented
         //if (!File.Exists(codingProjectsUrl + "\\meta.txt"))
         //   makeCodingProjectsSaveFile();
         //readCodingProjectsSaveFile();
      }

      public void makeBehavioralSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //File.WriteAllText(filePath, "0\n0\n0\n");
      }

      public void writeBehavioralSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //string str = manager.getNextProjectID() + "\n";
         //str += manager.getNextTaskID() + "\n";
         //str += manager.getNextGoalID() + "\n";
         //File.WriteAllText(filePath, str);
      }

      public void readBehavioralSaveFile() {
         // to be implemented
         //var reader = new StreamReader(codingProjectsUrl + "\\meta.txt");
         //manager.setNextProjectID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextTaskID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextGoalID(Convert.ToInt32(reader.ReadLine()));
      }

      #endregion

      // setter method
      public void setBehavioralUrl(string param) { behavioralUrl = param; }
   }
}
