using HackerCentral.Common;

namespace HackerCentral.Research {
   public class ResearchIO : IO{
      private string researchUrl;

      public ResearchIO(string url) {
         researchUrl = url;
      }

      // setters
      public void setResearchUrl(string param) { researchUrl = param; }
   }
}
