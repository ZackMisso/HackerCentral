using System;
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
         var files = Directory.GetFiles(getGoalUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var goal = new ResearchGoal();
               if (contents[0].Equals("ResearchReadingsGoal"))
                  list.Add(readResearchReadingsGoal(contents));
               // to be implemented more
               //list.Add(goal);
            }
         }
         return list;
      }

      private ResearchGoal readResearchReadingsGoal(string[] contents) {
         var goal = new ResearchReadingsGoal();
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
         goal.setPercentAccomplished(Convert.ToDouble(contents[4]));
         var toReads = Convert.ToInt32(contents[5]);
         var itr = 6;
         for (var i = 0; i < toReads; i++)
            goal.getToReadIDs().Add(Convert.ToInt32(contents[itr++]));
         goal.setTotalPages(Convert.ToInt32(contents[itr++]));
         goal.setPagesRead(Convert.ToInt32(contents[itr++]));
         goal.setGoalBasedOnReadings(contents[itr++].Equals("true"));
         goal.setGoalBasedOnPages(contents[itr++].Equals("true"));
         goal.setAllReadings(contents[itr++].Equals("true"));
         return goal;
      }

      public void writeGoalsToFiles(List<ResearchGoal> list) {
         foreach (ResearchGoal goal in list) {
            var filePath = getGoalUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public List<ResearchGoal> readGoalsFromHistory() {
         var list = new List<ResearchGoal>();
         var files = Directory.GetFiles(getGoalHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               //var goal = new ResearchGoal();
               if (contents[0].Equals("ResearchReadingsGoal"))
                  list.Add(readResearchReadingsGoal(contents));
               // to be implemented
               //list.Add(goal);
            }
         }
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
         var files = Directory.GetFiles(getReadingUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var reading = new ResearchReading();
               reading.setTitle(contents[0]);
               reading.setPath(contents[1]);
               reading.setNotesPath(contents[2]);
               reading.setPagesRead(Convert.ToInt32(contents[3]));
               reading.setTotalPages(Convert.ToInt32(contents[4]));
               reading.setIsFile(contents[5].Equals("true"));
               reading.setIsUrl(contents[6].Equals("true"));
               reading.setDone(contents[7].Equals("true"));
               var goals = Convert.ToInt32(contents[8]);
               var itr = 9;
               for (var i = 0; i < goals; i++)
                  reading.getGoalIDs().Add(Convert.ToInt32(contents[itr++]));
               var tasks = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < tasks; i++)
                  reading.getTaskIDs().Add(Convert.ToInt32(contents[itr++]));
               list.Add(reading);
            }
         }
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
         var files = Directory.GetFiles(getReadingHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var reading = new ResearchReading();
               reading.setTitle(contents[0]);
               reading.setPath(contents[1]);
               reading.setNotesPath(contents[2]);
               reading.setPagesRead(Convert.ToInt32(contents[3]));
               reading.setTotalPages(Convert.ToInt32(contents[4]));
               reading.setIsFile(contents[5].Equals("true"));
               reading.setIsUrl(contents[6].Equals("true"));
               reading.setDone(contents[7].Equals("true"));
               var goals = Convert.ToInt32(contents[8]);
               var itr = 9;
               for (var i = 0; i < goals; i++)
                  reading.getGoalIDs().Add(Convert.ToInt32(contents[itr++]));
               var tasks = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < tasks; i++)
                  reading.getTaskIDs().Add(Convert.ToInt32(contents[itr++]));
               list.Add(reading);
            }
         }
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
         var files = Directory.GetFiles(getTaskUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               if (contents[0].Equals("ResearchReadingTask"))
                  list.Add(readResearchReadingTask(contents));
            }
         }
         return list;
      }

      private ResearchTask readResearchReadingTask(string[] contents) {
         var task = new ResearchReadingTask();
         task.setReadingID(Convert.ToInt32(contents[1]));
         task.setPagesToRead(Convert.ToInt32(contents[2]));
         task.setPagesRead(Convert.ToInt32(contents[3]));
         task.setTakeNotes(contents[4].Equals("true"));
         task.setReadAll(contents[5].Equals("true"));
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
         return task;
      }

      public void writeTasksToFiles(List<ResearchTask> list) {
         foreach (ResearchTask task in list) {
            var filePath = getTaskUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public List<ResearchTask> readTasksFromHistory() {
         var list = new List<ResearchTask>();
         var files = Directory.GetFiles(getTaskHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               if (contents[0].Equals("ResearchReadingTask"))
                  list.Add(readResearchReadingTask(contents));
            }
         }
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

      #region MetaData

      public void checkResearchSaveFile() {
         // To be implemented
         //if (!File.Exists(codingProjectsUrl + "\\meta.txt"))
         //   makeCodingProjectsSaveFile();
         //readCodingProjectsSaveFile();
      }

      public void makeResearchSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //File.WriteAllText(filePath, "0\n0\n0\n");
      }

      public void writeResearchSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //string str = manager.getNextProjectID() + "\n";
         //str += manager.getNextTaskID() + "\n";
         //str += manager.getNextGoalID() + "\n";
         //File.WriteAllText(filePath, str);
      }

      public void readResearchSaveFile() {
         // to be implemented
         //var reader = new StreamReader(codingProjectsUrl + "\\meta.txt");
         //manager.setNextProjectID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextTaskID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextGoalID(Convert.ToInt32(reader.ReadLine()));
      }

      #endregion

      // setters
      public void setResearchUrl(string param) { researchUrl = param; }
   }
}
