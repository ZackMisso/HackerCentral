using System.IO;
using HackerCentral.Common;

namespace HackerCentral.Research {
   public class ResearchIO : IO{
      private string researchUrl;

      public ResearchIO(string url) {
         researchUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(researchUrl + "\\Tasks"))
            Directory.CreateDirectory(researchUrl + "\\Tasks");
         if (!Directory.Exists(researchUrl + "\\Goals"))
            Directory.CreateDirectory(researchUrl + "\\Goals");
         if (!Directory.Exists(researchUrl + "\\Readings"))
            Directory.CreateDirectory(researchUrl + "\\Readings");
         if (!Directory.Exists(researchUrl + "\\History"))
            Directory.CreateDirectory(researchUrl + "\\History");
         if (!Directory.Exists(researchUrl + "\\History\\Tasks"))
            Directory.CreateDirectory(researchUrl + "\\History\\Tasks");
         if (!Directory.Exists(researchUrl + "\\History\\Goals"))
            Directory.CreateDirectory(researchUrl + "\\History\\Goals");
         if (!Directory.Exists(researchUrl + "\\History\\Readings"))
            Directory.CreateDirectory(researchUrl + "\\History\\Readings");
      }

      // setters
      public void setResearchUrl(string param) { researchUrl = param; }
   }
}
