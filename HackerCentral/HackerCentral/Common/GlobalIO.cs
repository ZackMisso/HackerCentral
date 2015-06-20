using HackerCentral.CodingProjects;

namespace HackerCentral.Common {
   public class GlobalIO : IO{
      private string globalUrl;
      private CodingProjectsIO codingProjectsIO;

      public GlobalIO() {
         id = 0;
         // to be implemented
         //initializeAllIO();
      }

      public GlobalIO(string url) {
         globalUrl = url;
         id = 0;
         //initializeAllIO();
      }

      public string getCodingProjectsDirectory() {
         // to be implemented
         return "";
      }

      // Add more as needed

      // getter methods
      public CodingProjectsIO getCodingProjectsIO() { return codingProjectsIO; }
   }
}
