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
         // to be implemented
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
         // to be implemented
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
         // to be implemented
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
         // to be implemented
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
         // to be implemented
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
         // to be implemented
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

      // setters
      public void setMusicUrl(string param) { musicUrl = param; }
   }
}
