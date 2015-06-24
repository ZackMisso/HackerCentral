using HackerCentral.Common;

namespace HackerCentral.Art {
   public class ArtIO : IO{
      private string artUrl;

      public ArtIO(string url) {
         artUrl = url;
      }

      // setter methods
      public void setArtUrl(string param) { artUrl = param; }
   }
}
