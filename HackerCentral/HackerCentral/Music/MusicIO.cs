using System;
using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicIO : IO{
      private MusicManager manager;
      private string musicUrl;

      public MusicIO(MusicManager param,string url) {
         manager = param;
         musicUrl = url;
      }

      #region Pieces

      public List<MusicPiece> readPiecesFromFiles() {
         var list = new List<MusicPiece>();
         var files = Directory.GetFiles(getPieceUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var piece = new MusicPiece();
               piece.setName(contents[0]);
               piece.setLocation(conetents[1]);
               piece.setIteration(Convert.ToInt32(contents[2]));
               piece.setPieceID(Convert.ToInt32(contents[3]));
               piece.setDone(contents[4].Equals("true"));
               list.Add(piece);
            }
         }
         return list;
      }

      public void writePiecesToFiles(List<MusicPiece> list) {
         foreach (MusicPiece piece in list) {
            var filePath = getPieceUrl() + piece.getName() + ".txt";
            File.WriteAllText(filePath, piece.ToString());
         }
      }

      public List<MusicPiece> readPiecesFromHistory() {
         var list = new List<MusicPiece>();
         var files = Directory.GetFiles(getPieceHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var piece = new MusicPiece();
               piece.setName(contents[0]);
               piece.setLocation(conetents[1]);
               piece.setIteration(Convert.ToInt32(contents[2]));
               piece.setPieceID(Convert.ToInt32(contents[3]));
               piece.setDone(contents[4].Equals("true"));
               list.Add(piece);
            }
         }
         return list;
      }

      public void writePiecesToHistory(List<MusicPiece> list) {
         foreach (MusicPiece piece in list) {
            var filePath = getPieceHistoryUrl() + piece.getName() + ".txt";
            File.WriteAllText(filePath, piece.ToString());
         }
      }

      public void writePieceToFile(MusicPiece piece) {
         var filePath = getPieceUrl() + piece.getName() + ".txt";
         File.WriteAllText(filePath, piece.ToString());
      }

      public void writePieceToHistory(MusicPiece piece) {
         var filePath = getPieceHistoryUrl() + piece.getName() + ".txt";
         File.WriteAllText(filePath, piece.ToString());
      }

      #endregion

      #region Tasks

      public List<MusicTask> readTasksFromFile() {
         var list = new List<MusicTask>();
         var files = Directory.GetFiles(getTaskUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var task = new MusicTask();
               task.setPieceID(Convert.ToInt32(contents[1]));
               task.setStartIteration(Convert.ToInt32(contents[2]));
               task.setEndIteration(Convert.ToInt32(contents[3]));
               task.setName(contents[4]);
               task.setTaskID(contents[5]);
               task.setEffort(Convert.ToInt32(contents[6]));
               var status = contents[7];
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
               task.setDescription(contents[8]);
               list.Add(task);
            }
         }
         return list;
      }

      public void writeTasksToFiles(List<MusicTask> list) {
         foreach (MusicTask task in list) {
            var filePath = getTaskUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public List<MusicTask> readTasksFromHistory() {
         var list = new List<MusicTask>();
         var files = Directory.GetFiles(getTaskHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var task = new MusicTask();
               task.setPieceID(Convert.ToInt32(contents[1]));
               task.setStartIteration(Convert.ToInt32(contents[2]));
               task.setEndIteration(Convert.ToInt32(contents[3]));
               task.setName(contents[4]);
               task.setTaskID(contents[5]);
               task.setEffort(Convert.ToInt32(contents[6]));
               var status = contents[7];
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
               task.setDescription(contents[8]);
               list.Add(task);
            }
         }
         return list;
      }

      public void writeTasksToHistory(List<MusicTask> list) {
         foreach (MusicTask task in list) {
            var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public void writeTaskToFile(MusicTask task) {
         var filePath = getTaskUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      public void writeTaskToHistory(MusicTask task) {
         var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      #endregion

      #region Goals

      public List<MusicGoal> readGoalsFromFiles() {
         var list = new List<MusicGoal>();
         var files = Directory.GetFiles(getGoalUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var goal = new MusicGoal();
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
               goal.setPieceID(Convert.ToInt32(contents[5]));
               goal.setIterations(Convert.ToInt32(contents[6]));
               goal.setStartIteration(Convert.ToInt32(contents[7]));
               goal.setTaskGoal(contents[8].Equals("true"));
               goal.setIterationsGoal(contents[9].Equals("true"));
               goal.setGenericIterationsGoal(contents[10].Equals("true"));
               var tasks = Convert.ToInt32(contents[11]);
               for (var i = 0; i < tasks; i++)
                  goal.getTaskIDs().Add(Convert.ToInt32(contents[12 + i]));
               list.Add(goal);
            }
         }
         return list;
      }

      public void writeGoalsToFiles(List<MusicGoal> list) {
         foreach (MusicGoal goal in list) {
            var filePath = getGoalUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public List<MusicGoal> readGoalsFromHistory() {
         var list = new List<MusicGoal>();
         var files = Directory.GetFiles(getGoalHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var goal = new MusicGoal();
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
               goal.setPieceID(Convert.ToInt32(contents[5]));
               goal.setIterations(Convert.ToInt32(contents[6]));
               goal.setStartIteration(Convert.ToInt32(contents[7]));
               goal.setTaskGoal(contents[8].Equals("true"));
               goal.setIterationsGoal(contents[9].Equals("true"));
               goal.setGenericIterationsGoal(contents[10].Equals("true"));
               var tasks = Convert.ToInt32(contents[11]);
               for (var i = 0; i < tasks; i++)
                  goal.getTaskIDs().Add(Convert.ToInt32(contents[12 + i]));
               list.Add(goal);
            }
         }
         return list;
      }

      public void writeGoalsToHistory(List<MusicGoal> list) {
         foreach (MusicGoal goal in list) {
            var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public void writeGoalToFile(MusicGoal goal) {
         var filePath = getGoalUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      public void writeGoalToHistory(MusicGoal goal) {
         var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      #endregion

      public void createDirectoryStructure() {
         if (!Directory.Exists(getTaskUrl())
            Directory.CreateDirectory(getTaskUrl());
         if (!Directory.Exists(getGoalUrl())
            Directory.CreateDirectory(getGoalUrl());
         if (!Directory.Exists(getPieceUrl())
            Directory.CreateDirectory(getPieceUrl());
         if (!Directory.Exists(getHistoryUrl())
            Directory.CreateDirectory(getHistoryUrl());
         if (!Directory.Exists(getTaskHistoryUrl())
            Directory.CreateDirectory(getTaskHistoryUrl());
         if (!Directory.Exists(getGoalHistoryUrl())
            Directory.CreateDirectory(getGoalHistoryUrl());
         if (!Directory.Exists(getPieceHistoryUrl())
            Directory.CreateDirectory(getPieceHistoryUrl());
      }

      private string getTaskUrl() { return musicUrl + "\\Tasks"; }
      private string getGoalUrl() { return musicUrl + "\\Goals"; }
      private string getPieceUrl() { return musicUrl + "\\Pieces"; }
      private string getHistoryUrl() { return musicUrl + "\\History"; }
      private string getTaskHistoryUrl() { return getHistoryUrl() + "\\Tasks"; }
      private string getGoalHistoryUrl() { return getHistoryUrl() + "\\Goals"; }
      private string getPieceHistoryUrl() { return getHistoryUrl() + "\\Pieces"; }

      #region MetaData

      public void checkMusicSaveFile() {
         // To be implemented
         //if (!File.Exists(codingProjectsUrl + "\\meta.txt"))
         //   makeCodingProjectsSaveFile();
         //readCodingProjectsSaveFile();
      }

      public void makeMusicSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //File.WriteAllText(filePath, "0\n0\n0\n");
      }

      public void writeMusicSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //string str = manager.getNextProjectID() + "\n";
         //str += manager.getNextTaskID() + "\n";
         //str += manager.getNextGoalID() + "\n";
         //File.WriteAllText(filePath, str);
      }

      public void readMusicSaveFile() {
         // to be implemented
         //var reader = new StreamReader(codingProjectsUrl + "\\meta.txt");
         //manager.setNextProjectID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextTaskID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextGoalID(Convert.ToInt32(reader.ReadLine()));
      }

      #endregion

      // setters
      public void setMusicUrl(string param) { musicUrl = param; }
   }
}
