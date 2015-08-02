using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

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
         // to be implemented
         return list;
      }

      public List<ArtTask> readTasksFromHistory() {
         var list = new List<ArtTask>();
         // to be implemented
         return list;
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
         // to be implemented
         return list;
      }

      public List<ArtGoal> readGoalsFromHistory() {
         var list = new List<ArtGoal>();
         // to be implemented
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
         // to be implemented
         return list;
      }

      public List<ArtPiece> readPiecesFromHistory() {
         var list = new List<ArtPiece>();
         // to be implemented
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
