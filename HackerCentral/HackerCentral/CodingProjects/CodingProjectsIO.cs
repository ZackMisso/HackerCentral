using System.Collections.Generic;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsIO {
      private string globalCodingProjectsUrl;

      public CodingProjectIO() {
         globalCodingProjectsUrl = "";
      }

      public List<CodingProject> readCodingProjectsFromFile(){
         var list = new List<CodingProject>();
         // to be implemented
         return list;
      }

      public int getLinesOfCodeForProject(string url, List<string> typesOfFiles){
         int lines = 0;
         // to be implemented
         return lines;
      }

      // setter methods
      public void setGlobalCodingProjectsUrl(string param) { globalCodingProjectsUrl = param; }
   }
}
