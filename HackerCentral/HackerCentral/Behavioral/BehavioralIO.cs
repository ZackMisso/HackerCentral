using HackerCentral.Common;

namespace HackerCentral.Behavioral {
   public class BehavioralIO : IO{
      private string behavioralUrl;

      public BehavioralIO(string url) {
         behavioralUrl = url;
      }

      // setter method
      public void setBehavioralUrl(string param) { behavioralUrl = param; }
   }
}
