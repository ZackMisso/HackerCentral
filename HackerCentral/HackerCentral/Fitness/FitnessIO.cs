using System;
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
         var files = Directory.GetFiles(getExerciseUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var exercise = new FitnessExercise();
               exercise.setExerciseID(Convert.ToInt32(contents[0]));
               exercise.setGoalID(Convert.ToInt32(contents[1]));
               exercise.setName(contents[2]);
               exercise.setTotalReps(Convert.ToInt32(contents[3]));
               exercise.setHasGoal(contents[4].Equals("true"));
               exercise.setUpdatesPerWeek(contents[5].Equals("true"));
               exercise.setUpdatesPerMonth(contents[6].Equals("true"));
               list.add(exercise);
            }
         }
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
         var files = Directory.GetFiles(getExerciseHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var exercise = new FitnessExercise();
               exercise.setExerciseID(Convert.ToInt32(contents[0]));
               exercise.setGoalID(Convert.ToInt32(contents[1]));
               exercise.setName(contents[2]);
               exercise.setTotalReps(Convert.ToInt32(contents[3]));
               exercise.setHasGoal(contents[4].Equals("true"));
               exercise.setUpdatesPerWeek(contents[5].Equals("true"));
               exercise.setUpdatesPerMonth(contents[6].Equals("true"));
               list.add(exercise);
            }
         }
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
         var files = Directory.GetFiles(getGoalUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var goal = new FitnessExerciseGoal();
               goal.setExerciseID(Convert.ToInt32(contents[1]));
               goal.setTotalReps(Convert.ToInt32(contents[2]));
               goal.setDailyReps(Convert.ToInt32(contents[3]));
               goal.setPerDay(contents[4].Equals("true"));
               var status = contents[5];
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
               goal.setName(contents[6]);
               goal.setGoalID(Convert.ToInt32(contents[7]));
               goal.setPercentAccomplished((float)Convert.ToDouble(contents[8));
               list.Add(goal);
            }
         }
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
         var files = Directory.GetFiles(getGoalHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var goal = new FitnessExerciseGoal();
               goal.setExerciseID(Convert.ToInt32(contents[1]));
               goal.setTotalReps(Convert.ToInt32(contents[2]));
               goal.setDailyReps(Convert.ToInt32(contents[3]));
               goal.setPerDay(contents[4].Equals("true"));
               var status = contents[5];
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
               goal.setName(contents[6]);
               goal.setGoalID(Convert.ToInt32(contents[7]));
               goal.setPercentAccomplished((float)Convert.ToDouble(contents[8));
               list.Add(goal);
            }
         }
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
         var files = Directory.GetFiles(getTaskUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var task = new FitnessTask();
               task.setExerciseID(Convert.ToInt32(contents[1]));
               task.setReps(Convert.ToInt32(contents[2]));
               task.setDaily(contents[3].Equals("true"));
               task.setWeekly(contents[4].Equals("true"));
               task.setMonthly(contents[5].Equals("true"));
               task.setName(contents[6]);
               task.setTaskID(contents[7]);
               task.setEffort(Convert.ToInt32(contents[8]));
               var status = contents[9];
               if (status.Equals("ToDo"))
                  task.setStatus(TaskStatusEnum.ToDo);
               else if (status.Equals("InProgress"))
                  task.setStatus(TaskStatusEnum.InProgress);
               else if (status.Equals("Done"))
                  task.setStatus(TaskStatusEnum.Done);
               else if (status.Equals("Canceled"))
                  task.setStatus(TaskStatusEnum.Canceled);
               else
                  task.setStatus(TaskStatusEnum.Failed);
               task.setDescription(contents[10]);
               list.Add(task);
            }
         }
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
         var files = Directory.GetFiles(getTaskHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var task = new FitnessTask();
               task.setExerciseID(Convert.ToInt32(contents[1]));
               task.setReps(Convert.ToInt32(contents[2]));
               task.setDaily(contents[3].Equals("true"));
               task.setWeekly(contents[4].Equals("true"));
               task.setMonthly(contents[5].Equals("true"));
               task.setName(contents[6]);
               task.setTaskID(contents[7]);
               task.setEffort(Convert.ToInt32(contents[8]));
               var status = contents[9];
               if (status.Equals("ToDo"))
                  task.setStatus(TaskStatusEnum.ToDo);
               else if (status.Equals("InProgress"))
                  task.setStatus(TaskStatusEnum.InProgress);
               else if (status.Equals("Done"))
                  task.setStatus(TaskStatusEnum.Done);
               else if (status.Equals("Canceled"))
                  task.setStatus(TaskStatusEnum.Canceled);
               else
                  task.setStatus(TaskStatusEnum.Failed);
               task.setDescription(contents[10]);
               list.Add(task);
            }
         }
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

      #region MetaData

      public void checkFitnessSaveFile() {
         // To be implemented
         //if (!File.Exists(codingProjectsUrl + "\\meta.txt"))
         //   makeCodingProjectsSaveFile();
         //readCodingProjectsSaveFile();
      }

      public void makeFitnessSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //File.WriteAllText(filePath, "0\n0\n0\n");
      }

      public void writeFitnessSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //string str = manager.getNextProjectID() + "\n";
         //str += manager.getNextTaskID() + "\n";
         //str += manager.getNextGoalID() + "\n";
         //File.WriteAllText(filePath, str);
      }

      public void readFitnessSaveFile() {
         // to be implemented
         //var reader = new StreamReader(codingProjectsUrl + "\\meta.txt");
         //manager.setNextProjectID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextTaskID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextGoalID(Convert.ToInt32(reader.ReadLine()));
      }

      #endregion

      // setters
      public void setFitnessUrl(string param) { fitnessUrl = param; }
   }
}
