using System;
using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;
using HackerCentral.Common.Enum;

namespace HackerCentral.Art {
   public class ArtIO : IO{
      private ArtManager manager;
      private string artUrl;

      public ArtIO(ArtManager param,string url) {
         manager = param;
         artUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(getTasksUrl())
            Directory.CreateDirectory(getTasksUrl);
         if (!Directory.Exists(getGoalsUrl())
            Directory.CreateDirectory(getGoalsUrl());
         if (!Directory.Exists(getPiecesUrl())
            Directory.CreateDirectory(getPiecesUrl());
         if (!Directory.Exists(getHistoryUrl())
            Directory.CreateDirectory(getHistoryUrl());
         if (!Directory.Exists(getTaskHistoryUrl())
            Directory.CreateDirectory(getTaskHistoryUrl());
         if (!Directory.Exists(getGoalHistoryUrl())
            Directory.CreateDirectory(getGoalHistoryUrl());
         if (!Directory.Exists(getPieceHistoryUrl())
            Directory.CreateDirectory(getPieceHistoryUrl());
      }

      private string getTaskUrl() { return artUrl + "\\Tasks"; }
      private string getGoalsUrl() { return artUrl + "\\Goals"; }
      private string getPiecesUrl() { return artUrl + "\\Pieces"; }
      private string getHistoryUrl() { return artUrl + "\\History"; }
      private string getTaskHistoryUrl() { return getHistoryUrl() + "\\Tasks"; }
      private string getGoalHistoryUrl() { return getHistoryUrl() + "\\Goals"; }
      private string getPieceHistoryUrl() { return getHistoryUrl() + "\\Pieces"; }

      #region Tasks

      public List<ArtTask> readTasksFromFiles() {
         var list = new List<ArtTask>();
         var files = Directory.GetFiles(GetTaskUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            var goal = new ArtGoal();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               if(contents[0].Equals("ArtPieceTask"))
                  list.Add(readArtPieceTask(contents));
               else if(contents[0].Equals("ArtIterationTask"))
                  list.Add(readArtIterationTask(contents));
            }
         }
         return list;
      }

      public List<ArtTask> readTasksFromHistory() {
         var list = new List<ArtTask>();
         var files = Directory.GetFiles(GetTaskHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            var goal = new ArtGoal();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               if(contents[0].Equals("ArtPieceTask"))
                  list.Add(readArtPieceTask(contents));
               else if(contents[0].Equals("ArtIterationTask"))
                  list.Add(readArtIterationTask(contents));
            }
         }
         return list;
      }

      public ArtTask readArtPieceTask(string[] contents){
         var task = new ArtPieceTask();
         task.setPieceID(Convert.ToInt32(contents[1]));
         task.setName(contents[2]);
         task.setTaskID(contents[3]);
         task.setEffort(Convert.ToInt32(contents[4]));
         var status = contents[5];
         if(status.Equals("ToDo"))
            task.setStatus(TaskStatusEnum.ToDo);
         else if(status.Equals("InProgress"))
            task.setStatus(TaskStatusEnum.InProgress);
         else if(status.Equals("Done"))
            task.setStatus(TaskStatusEnum.Done);
         else if(status.Equals("Canceled"))
            task.setStatus(TaskStatusEnum.Canceled);
         else
            task.setStatus(TaskStatusEnum.Failed);
         task.setDescription(contents[6]);
         return task;
      }

      public ArtTask readArtIterationTask(string[] contents){
         var task = new ArtIterationTask();
         task.setPieceID(Convert.ToInt32(contents[1]));
         task.setStartIteration(Convert.ToInt32(contents[2]));
         task.setEndIteration(Convert.ToInt32(contents[3]));
         task.setName(contents[4]);
         task.setTaskID(contents[5]);
         task.setEffort(Convert.ToInt32(contents[6]));
         var status = contents[7];
         if(status.Equals("ToDo"))
            task.setStatus(TaskStatusEnum.ToDo);
         else if(status.Equals("InProgress"))
            task.setStatus(TaskStatusEnum.InProgress);
         else if(status.Equals("Done"))
            task.setStatus(TaskStatusEnum.Done);
         else if(status.Equals("Canceled"))
            task.setStatus(TaskStatusEnum.Canceled);
         else
            task.setStatus(TaskStatusEnum.Failed);
         task.setDescription(contents[8]);
         return tasl;
      }

      public void writeTasksToFiles(List<ArtTask> list) {
         foreach (ArtTask task in list) {
            var filePath = getTaskUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public void writeTaskToFile(ArtTask task) {
         var filePath = getTaskUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      public void writeTasksToHistory(List<ArtTask> list) {
         foreach (ArtTask task in list) {
            var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
            using (StreamWriter sw = File.AppendText(filePath))
               sw.WriteLine(task.ToString());
         }
      }

      public void writeTaskToHistory(ArtTask task) {
         var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
         using (StreamWriter sw = File.AppendText(filePath))
            sw.WriteLine(task.ToString());
      }

      #endregion

      #region Goals

      public List<ArtGoal> readGoalsFromFiles() {
         var list = new List<ArtGoal>();
         var files = Directory.GetFiles(GetGoalUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            var goal = new ArtGoal();
            string line;
            while ((line = reader.ReadLine()) != null) {
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
               goal.setPercentComplete((float)Convert.ToDouble(contents[4]));
               var numOfTasks = Convert.ToInt32(contents[5]);
               int num = 5;
               for (int i = 0; i < numOfTasks; i++) {
                  goal.getTaskIDs().Add(contents[6] + i);
                  num++;
               }
               goal.setNumberOfTasks(Convert.ToInt32(contents[num++]));
               goal.setFinishedTasks(Convert.ToInt32(contents[num++]));
               goal.setAllTasks(contents[num].Equals("true"));
               list.Add(goal);
            }
         }
         return list;
      }

      public List<ArtGoal> readGoalsFromHistory() {
         var list = new List<ArtGoal>();
         var files = Directory.GetFiles(GetGoalHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            var goal = new ArtGoal();
            string line;
            while ((line = reader.ReadLine()) != null) {
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
               goal.setPercentComplete((float)Convert.ToDouble(contents[4]));
               var numOfTasks = Convert.ToInt32(contents[5]);
               int num = 5;
               for (int i = 0; i < numOfTasks; i++) {
                  goal.getTaskIDs().Add(contents[6] + i);
                  num++;
               }
               goal.setNumberOfTasks(Convert.ToInt32(contents[num++]));
               goal.setFinishedTasks(Convert.ToInt32(contents[num++]));
               goal.setAllTasks(contents[num].Equals("true"));
               list.Add(goal);
            }
         }
         return list;
      }

      public void writeGoalsToFiles(List<ArtGoal> list) {
         foreach (ArtGoal goal in list) {
            var filePath = getGoalUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public void writeGoalToFile(ArtGoal goal) {
         var filePath = getGoalUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      public void writeGoalsToHistory(List<ArtGoal> list) {
         foreach (ArtGoal goal in list) {
            var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
            using (StreamWriter sw = File.AppendText(filePath))
               sw.WriteLine(goal.ToString());
         }
      }

      public void writeGoalToHistory(ArtGoal goal) {
         var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
         using (StreamWriter sw = File.AppendText(filePath))
            sw.WriteLine(goal.ToString());
      }

      #endregion

      #region Pieces

      public List<ArtPiece> readPiecesFromFiles() {
         var list = new List<ArtPiece>();
         var files = Directory.GetFiles(GetPieceUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            var piece = new ArtPiece();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               piece.setPieceID(Convert.ToInt32(contents[0]));
               piece.setBegin(null); // read in begin date time
               piece.setFinished(null); // read in finished date time
               piece.setIteration(Convert.ToInt32(contents[3]));
               piece.setFile(contents[4]);
               piece.setFormat(contents[5]);
               piece.setName(contents[6]);
               list.Add(piece);
            }
         return list;
      }

      public List<ArtPiece> readPiecesFromHistory() {
         var list = new List<ArtPiece>();
         var files = Directory.GetFiles(GetPieceHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            var piece = new ArtPiece();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               piece.setPieceID(Convert.ToInt32(contents[0]));
               piece.setBegin(null); // read in begin date time
               piece.setFinished(null); // read in finished date time
               piece.setIteration(Convert.ToInt32(contents[3]));
               piece.setFile(contents[4]);
               piece.setFormat(contents[5]);
               piece.setName(contents[6]);
               list.Add(piece);
            }
         return list;
      }

      public void writePiecesToFiles(List<ArtPiece> list) {
         foreach (ArtPiece piece in list) {
            var filePath = getPieceUrl() + piece.getName() + ".txt";
            File.WriteAllText(filePath, piece.ToString());
         }
      }

      public void writePieceToFile(ArtPiece piece) {
         var filePath = getPieceUrl() + piece.getName() + ".txt";
         File.WriteAllText(filePath, piece.ToString());
      }

      public void writePiecesToHistory(List<ArtPiece> list) {
         foreach (ArtPiece piece in list) {
            var filePath = getPieceHistoryUrl() + piece.getName() + ".txt";
            using (StreamWriter sw = File.AppendText(filePath))
               sw.WriteLine(piece.ToString());
         }
      }

      public void writePieceToHistory(ArtPiece piece) {
         var filePath = getPieceHistoryUrl() + piece.getName() + ".txt";
         using (StreamWriter sw = File.AppendText(filePath))
            sw.WriteLine(piece.ToString());
      }

      #endregion

      // setter methods
      public void setArtUrl(string param) { artUrl = param; }
   }
}
