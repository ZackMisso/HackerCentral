using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolIO : IO{
      private string schoolUrl;

      public SchoolIO(string url) {
         schoolUrl = url;
      }

      // setters
      public void setSchoolUrl(string param) { schoolUrl = param; }
   }
}
