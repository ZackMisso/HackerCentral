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

      public List<MusicPiece> readPiecesFromFiles() {
         var list = new List<MusicPiece>();
         // to be implemented
         return list;
      }

      public void writePiecesToFiles(List<MusicPiece> list) {
         // to be implemented
      }

      public List<MusicPiece> readPiecesFromHistory() {
         var list = new List<MusicPiece>();
         // to be implemented
         return list;
      }

      public void writePiecesToHistory(List<MusicPiece> list) {
         // to be implemented
      }

      public List<MusicTask> readTasksFromFile() {
         var list = new List<MusicTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<MusicTask> list) {
         // to be implemented
      }

      public List<MusicTask> readTasksFromHistory() {
         var list = new List<MusicTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToHistory(List<MusicTask> list) {
         // to be implemented
      }

      public List<MusicGoal> readGoalsFromFiles() {
         var list = new List<MusicGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToFiles(List<MusicGoal> list) {
         // to be implemented
      }

      public List<MusicGoal> readGoalsFromHistory() {
         var list = new List<MusicGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<MusicGoal> list) {
         // to be implemented
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(musicUrl + "\\Tasks"))
            Directory.CreateDirectory(musicUrl + "\\Tasks");
         if (!Directory.Exists(musicUrl + "\\Goals"))
            Directory.CreateDirectory(musicUrl + "\\Goals");
         if (!Directory.Exists(musicUrl + "\\Pieces"))
            Directory.CreateDirectory(musicUrl + "\\Pieces");
         if (!Directory.Exists(musicUrl + "\\History"))
            Directory.CreateDirectory(musicUrl + "\\History");
         if (!Directory.Exists(musicUrl + "\\History\\Tasks"))
            Directory.CreateDirectory(musicUrl + "\\History\\Tasks");
         if (!Directory.Exists(musicUrl + "\\History\\Goals"))
            Directory.CreateDirectory(musicUrl + "\\History\\Goals");
         if (!Directory.Exists(musicUrl + "\\History\\Pieces"))
            Directory.CreateDirectory(musicUrl + "\\History\\Pieces");
      }

      // setters
      public void setMusicUrl(string param) { musicUrl = param; }
   }
}
