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
         // to be implemented
      }

      public List<ResearchGoal> readGoalsFromHistory() {
         var list = new List<ResearchGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<ResearchGoal> list) {
         // to be implemented
      }

      public void writeGoalToFile(ResearchGoal goal) {
         // to be implemented
      }

      public void writeGoalToHistory(ResearchGoal goal) {
         // to be implemented
      }

      #endregion

      #region Readings

      public List<ResearchReading> readReadingsFromFiles() {
         var list = new List<ResearchReading>();
         // to be implemented
         return list;
      }

      public void writeReadingsToFiles(List<ResearchReading> list) {
         // to be implemented
      }

      public List<ResearchReading> readReadingsFromHistory() {
         var list = new List<ResearchReading>();
         // to be implemented
         return list;
      }

      public void writeReadingsToHistory(List<ResearchReading> list) {
         // to be implemented
      }

      public void writeReadingToFile(ResearchReading reading) {
         // to be implemented
      }

      public void writeReadingToHistory(ResearchReading reading) {
         // to be implemented
      }

      #endregion

      #region Tasks

      public List<ResearchTask> readTasksFromFiles() {
         var list = new List<ResearchTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<ResearchTask> list) {
         // to be implemented
      }

      public List<ResearchTask> readTasksFromHistory() {
         var list = new List<ResearchTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToHistory(List<ResearchTask> list) {
         // to be implemented
      }

      public void writeTaskToFile(ResearchTask task) {
         // to be implemented
      }

      public void writeTaskToHistory(ResearchTask task) {
         // to be implemented
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
