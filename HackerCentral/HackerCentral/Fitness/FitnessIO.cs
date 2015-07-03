using System.IO;
using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessIO : IO{
      private string fitnessUrl;

      public FitnessIO(string url) {
         fitnessUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(fitnessUrl + "\\Exercises"))
            Directory.CreateDirectory(fitnessUrl + "\\Exercises");
         if (!Directory.Exists(fitnessUrl + "\\Goals"))
            Directory.CreateDirectory(fitnessUrl + "\\Goals");
         if (!Directory.Exists(fitnessUrl + "\\History"))
            Directory.CreateDirectory(fitnessUrl + "\\History");
         if (!Directory.Exists(fitnessUrl + "\\History\\Exercises"))
            Directory.CreateDirectory(fitnessUrl + "\\History\\Exerciess");
         if (!Directory.Exists(fitnessUrl + "\\History\\Goals"))
            Directory.CreateDirectory(fitnessUrl + "\\History\\Goals");
      }

      // setters
      public void setFitnessUrl(string param) { fitnessUrl = param; }
   }
}
