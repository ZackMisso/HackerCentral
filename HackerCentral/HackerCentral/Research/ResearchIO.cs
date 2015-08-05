using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Research {
   public class ResearchIO : IO{
      private ResearchManager manager;
      private string researchUrl;

      public ResearchIO(ResearchManager param,string url) {
         manager = param;
         researchUrl = url;
      }

      #region Goals

      public List<ResearchGoal> readGoalsFromFiles() {
         var list = new List<ResearchGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToFiles(List<ResearchGoal> list) {
         foreach (ResearchGoal goal in list) {
            var filePath = getGoalUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public List<ResearchGoal> readGoalsFromHistory() {
         var list = new List<ResearchGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<ResearchGoal> list) {
         foreach (ResearchGoal goal in list) {
            var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public void writeGoalToFile(ResearchGoal goal) {
         var filePath = getGoalUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      public void writeGoalToHistory(ResearchGoal goal) {
         var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      #endregion

      #region Readings

      public List<ResearchReading> readReadingsFromFiles() {
         var list = new List<ResearchReading>();
         // to be implemented
         return list;
      }

      public void writeReadingsToFiles(List<ResearchReading> list) {
         foreach (ResearchReading reading in list) {
            var filePath = getReadingUrl() + reading.getName() + ".txt";
            File.WriteAllText(filePath, reading.ToString());
         }
      }

      public List<ResearchReading> readReadingsFromHistory() {
         var list = new List<ResearchReading>();
         // to be implemented
         return list;
      }

      public void writeReadingsToHistory(List<ResearchReading> list) {
         foreach (ResearchReading reading in list) {
            var filePath = getReadingHistoryUrl() + reading.getName() + ".txt";
            File.WriteAllText(filePath, reading.ToString());
         }
      }

      public void writeReadingToFile(ResearchReading reading) {
         var filePath = getReadingUrl() + reading.getName() + ".txt";
         File.WriteAllText(filePath, reading.ToString());
      }

      public void writeReadingToHistory(ResearchReading reading) {
         var filePath = getReadingHistoryUrl() + reading.getName() + ".txt";
         File.WriteAllText(filePath, reading.ToString());
      }

      #endregion

      #region Tasks

      public List<ResearchTask> readTasksFromFiles() {
         var list = new List<ResearchTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<ResearchTask> list) {
         foreach (ResearchTask task in list) {
            var filePath = getTaskUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public List<ResearchTask> readTasksFromHistory() {
         var list = new List<ResearchTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToHistory(List<ResearchTask> list) {
         foreach (ResearchTask task in list) {
            var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public void writeTaskToFile(ResearchTask task) {
         var filePath = getTaskUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      public void writeTaskToHistory(ResearchTask task) {
         var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      #endregion

      public void createDirectoryStructure() {
         if (!Directory.Exists(getTaskUrl())
            Directory.CreateDirectory(getTaskUrl());
         if (!Directory.Exists(getGoalUrl())
            Directory.CreateDirectory(getGoalUrl());
         if (!Directory.Exists(getReadingUrl())
            Directory.CreateDirectory(getReadingUrl());
         if (!Directory.Exists(getHistoryUrl())
            Directory.CreateDirectory(getHistoryUrl());
         if (!Directory.Exists(getTaskHistoryUrl())
            Directory.CreateDirectory(getTaskHistoryUrl());
         if (!Directory.Exists(getGoalHistoryUrl())
            Directory.CreateDirectory(getGoalHistoryUrl());
         if (!Directory.Exists(getReadingHistoryUrl())
            Directory.CreateDirectory(getReadingHistoryUrl());
      }

      private string getTaskUrl() { return researchUrl + "\\Tasks"; }
      private string getGoalUrl() { return researchUrl + "\\Goals"; }
      private string getReadingUrl() { return researchUrl + "\\Readings"; }
      private string getHistoryUrl() { return researchUrl + "\\History"; }
      private string getTaskHistoryUrl() { return getHistoryUrl() + "\\Tasks"; }
      private string getGoalHistoryUrl() { return getHistoryUrl() + "\\Goals"; }
      private string getReadingHistoryUrl() { return getHistoryUrl() + "\\Readings"; }

      // setters
      public void setResearchUrl(string param) { researchUrl = param; }
   }
}
