using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicIO : IO{
      private string musicUrl;

      public MusicIO(string url) {
         musicUrl = url;
      }

      // setters
      public void setMusicUrl(string param) { musicUrl = param; }
   }
}
