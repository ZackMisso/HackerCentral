using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessIO : IO{
      private FitnessManager manager;
      private string fitnessUrl;

      public FitnessIO(FitnessManager param,string url) {
         manager = param;
         fitnessUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(getExerciseUrl())
            Directory.CreateDirectory(getExerciseUrl());
         if (!Directory.Exists(getGoalUrl())
            Directory.CreateDirectory(getGoalUrl());
         if (!Directory.Exists(getTaskUrl())
            Directory.CreateDirectory(getTaskUrl());
         if (!Directory.Exists(getHistoryUrl())
            Directory.CreateDirectory(getHistoryUrl());
         if (!Directory.Exists(getExerciseHistoryUrl())
            Directory.CreateDirectory(getExerciseHistoryUrl());
         if (!Directory.Exists(getGoalHistoryUrl())
            Directory.CreateDirectory(getGoalHistoryUrl());
         if (!Directory.Exists(getTaskHistoryUrl())
            Directory.CreateDirectory(getTaskHistoryUrl());
      }

      private string getExerciseUrl() { return fitnessUrl + "\\Exercises"; }
      private string getGoalUrl() { return fitnessUrl + "\\Goals"; }
      private string getTaskUrl() { return fitnessUrl + "\\Tasks"; }
      private string getHistoryUrl() { return fitnessUrl + "\\History"; }
      private string getExerciseHistoryUrl() { return getHistoryUrl() + "\\Exercises"; }
      private string getGoalHistoryUrl() { return getHistoryUrl() + "\\Goals"; }
      private string getTaskHistoryUrl() { return getHistoryUrl() + "\\Tasks"; }

      #region Exercise

      public List<FitnessExercise> readExcercisesFromFiles() {
         var list = new List<FitnessExercise>();
         // to be implemented
         return list;
      }

      public void writeExercisesToFiles(List<FitnessExercise> list) {
         // to be implemented
      }

      public List<FitnessExercise> readExercisesFromHistory() {
         var list = new List<FitnessExercise>();
         // to be implemented
         return list;
      }

      public void writeExercisesToHistory(List<FitnessExercise> list) {
         // to be implemented
      }

      public void writeExerciseToFile(FitnessExercise exercise) {
         // to be implemented
      }

      public void writeExerciseToHistory(FitnessExercise exercise) {
         // to be implemented
      }

      #endregion

      #region Goals

      public List<FitnessExerciseGoal> readExerciseGoalFromFiles() {
         var list = new List<FitnessExerciseGoal>();
         // to be implemented
         return list;
      }

      public void writeExerciseGoalsToFiles(List<FitnessExerciseGoal> list) {
         // to be implemented
      }

      public List<FitnessExerciseGoal> readExerciseGoalFromHistory() {
         var list = new List<FitnessExerciseGoal>();
         // to be implemented
         return list;
      }

      public void writeExerciseGoalToHistory(List<FitnessExerciseGoal> list) {
         // to be implemented
      }

      public void writeExerciseGoalToFile(FitnessExerciseGoal goal) {
         // to be implemented
      }

      public void writeExerciseGoalToHistory(FitnessExerciseGoal goal) {
         // to be implemented
      }

      #endregion

      #region Tasks

      public List<FitnessTask> readTasksFromFiles() {
         var list = new List<FitnessTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<FitnessTask> list) {
         // to be implemented
      }

      public List<FitnessTask> readTasksFromHistory() {
         var list = new List<FitnessTask>();
         // to be implemented
         return list;
      }

      public void writeFitnessTaskToHistory(List<FitnessTask> list) {
         // to be implemented
      }

      #endregion

      // setters
      public void setFitnessUrl(string param) { fitnessUrl = param; }
   }
}
