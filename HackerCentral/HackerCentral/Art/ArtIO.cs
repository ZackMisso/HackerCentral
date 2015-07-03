using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Art {
   public class ArtIO : IO{
      private string artUrl;

      public ArtIO(string url) {
         artUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(artUrl + "\\Tasks"))
            Directory.CreateDirectory(artUrl + "\\Tasks");
         if (!Directory.Exists(artUrl + "\\Goals"))
            Directory.CreateDirectory(artUrl + "\\Goals");
         if (!Directory.Exists(artUrl + "\\Pieces"))
            Directory.CreateDirectory(artUrl + "\\Pieces");
         if (!Directory.Exists(artUrl + "\\History"))
            Directory.CreateDirectory(artUrl + "\\History");
         if (!Directory.Exists(artUrl + "\\History\\Tasks"))
            Directory.CreateDirectory(artUrl + "\\History\\Tasks");
         if (!Directory.Exists(artUrl + "\\History\\Goals"))
            Directory.CreateDirectory(artUrl + "\\History\\Goals");
         if (!Directory.Exists(artUrl + "\\History\\Pieces"))
            Directory.CreateDirectory(artUrl + "\\History\\Pieces");
      }

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

      // setter methods
      public void setArtUrl(string param) { artUrl = param; }
   }
}
