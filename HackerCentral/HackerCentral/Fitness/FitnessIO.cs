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
         foreach (FitnessExercise exercise in list) {
            var filePath = getExerciseUrl() + exercise.getName() + ".txt";
            File.WriteAllText(filePath, exercise.ToString());
         }
      }

      public List<FitnessExercise> readExercisesFromHistory() {
         var list = new List<FitnessExercise>();
         // to be implemented
         return list;
      }

      public void writeExercisesToHistory(List<FitnessExercise> list) {
         foreach (FitnessExercise exercise in list) {
            var filePath = getExerciseHistoryUrl() + exercise.getName() + ".txt";
            File.WriteAllText(filePath, exercise.ToString());
         }
      }

      public void writeExerciseToFile(FitnessExercise exercise) {
         var filePath = getExerciseUrl() + exercise.getName() + ".txt";
         File.WriteAllText(filePath, exercise.ToString());
      }

      public void writeExerciseToHistory(FitnessExercise exercise) {
         var filePath = getExerciseHistoryUrl() + exercise.getName() + ".txt";
         File.WriteAllText(filePath, exercise.ToString());
      }

      #endregion

      #region Goals

      public List<FitnessExerciseGoal> readExerciseGoalFromFiles() {
         var list = new List<FitnessExerciseGoal>();
         // to be implemented
         return list;
      }

      public void writeExerciseGoalsToFiles(List<FitnessExerciseGoal> list) {
         foreach (FitnessExerciseGoal goal in list) {
            var filePath = getGoalUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public List<FitnessExerciseGoal> readExerciseGoalFromHistory() {
         var list = new List<FitnessExerciseGoal>();
         // to be implemented
         return list;
      }

      public void writeExerciseGoalToHistory(List<FitnessExerciseGoal> list) {
         foreach (FitnessExerciseGoal goal in list) {
            var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public void writeExerciseGoalToFile(FitnessExerciseGoal goal) {
         var filePath = getGoalUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      public void writeExerciseGoalToHistory(FitnessExerciseGoal goal) {
         var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      #endregion

      #region Tasks

      public List<FitnessTask> readTasksFromFiles() {
         var list = new List<FitnessTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<FitnessTask> list) {
         foreach (FitnessTask task in list) {
            var filePath = getTaskUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public List<FitnessTask> readTasksFromHistory() {
         var list = new List<FitnessTask>();
         // to be implemented
         return list;
      }

      public void writeFitnessTaskToHistory(List<FitnessTask> list) {
         foreach (FitnessTask task in list) {
            var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public void writeFitnessTaskToFile(FitnessTask task) {
         var filePath = getTaskUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      public void writeFitnessTaskToHistory(FitnessTask task) {
         var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      #endregion

      // setters
      public void setFitnessUrl(string param) { fitnessUrl = param; }
   }
}
