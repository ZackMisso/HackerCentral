using HackerCentral.Common;

namespace HackerCentral.Finances {
   public class FinancesIO : IO{
      private string financesUrl;

      public FinancesIO(string url) {
         financesUrl = url;
      }

      // setters
      public void setFinancesUrl(string param) { financesUrl = param; }
   }
}
