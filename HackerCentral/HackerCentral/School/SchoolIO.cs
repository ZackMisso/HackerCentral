using System.IO;
using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolIO : IO{
      private string schoolUrl;

      public SchoolIO(string url) {
         schoolUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(schoolUrl + "\\Assignments"))
            Directory.CreateDirectory(schoolUrl + "\\Assignments");
         if (!Directory.Exists(schoolUrl + "\\Goals"))
            Directory.CreateDirectory(schoolUrl + "\\Goals");
         if (!Directory.Exists(schoolUrl + "\\Classes"))
            Directory.CreateDirectory(schoolUrl + "\\Classes");
         if (!Directory.Exists(schoolUrl + "\\History"))
            Directory.CreateDirectory(schoolUrl + "\\History");
         if (!Directory.Exists(schoolUrl + "\\History\\Assignments"))
            Directory.CreateDirectory(schoolUrl + "\\History\\Assignments");
         if (!Directory.Exists(schoolUrl + "\\History\\Goals"))
            Directory.CreateDirectory(schoolUrl + "\\History\\Goals");
         if (!Directory.Exists(schoolUrl + "\\History\\Classes"))
            Directory.CreateDirectory(schoolUrl + "\\History\\Classes");
      }

      // setters
      public void setSchoolUrl(string param) { schoolUrl = param; }
   }
}
