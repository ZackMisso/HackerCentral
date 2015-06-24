using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessIO : IO{
      private string fitnessUrl;

      public FitnessIO(string url) {
         fitnessUrl = url;
      }

      // setters
      public void setFitnessUrl(string param) { fitnessUrl = param; }
   }
}
