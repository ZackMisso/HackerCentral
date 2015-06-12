namespace HackerCentral.Common {
   public class GlobalIO {
      private string globalUrl;
      private CodingProjectsIO codingProjectsIO;

      public GlobalIO(string url) {
         globalUrl = url;
         initializeAllIO();
      }

      private void initializeAllIO() {
         // to be implemented
      }

      // getter methods
      public CodingProjectsIO getCodingProjectsIO() { return codingProjectsIO; }
   }
}
