using System.IO;
using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicIO : IO{
      private string musicUrl;

      public MusicIO(string url) {
         musicUrl = url;
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
