using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Finances {
   public class FinancesIO : IO{
      private string financesUrl;

      public FinancesIO(string url) {
         financesUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(financesUrl + "\\Transactions"))
            Directory.CreateDirectory(financesUrl + "\\Transactions");
         if (!Directory.Exists(financesUrl + "\\Budget"))
            Directory.CreateDirectory(financesUrl + "\\Budget");
         if (!Directory.Exists(financesUrl + "\\History"))
            Directory.CreateDirectory(financesUrl + "\\History");
         if (!Directory.Exists(financesUrl + "\\History\\Transactions"))
            Directory.CreateDirectory(financesUrl + "\\History\\Transactions");
         if (!Directory.Exists(financesUrl + "\\History\\Budget"))
            Directory.CreateDirectory(financesUrl + "\\History\\Budget");
      }

      public List<FinancesTransaction> readTransactionsFromFiles() {
         var list = new List<FinancesTransaction>();
         // to be implemented
         return list;
      }

      public void writeTransactionsToFiles(List<FinancesTransaction> list) {
         // to be implemented
      }

      public List<FinancesTransaction> readTransactionsFromHistory() {
         var list = new List<FinancesTransaction>();
         // to be implemented
         return list;
      }

      public void writeTransactionsToHistory(List<FinancesTransaction> list) {
         // to be implemented
      }

      public List<FinancesBudget> readBudgetFromFiles() {
         var list = new List<FinancesBudget>();
         // to be implemented
         return list;
      }

      public void writeBudgetToFiles(List<FinancesBudget> list) {
         // to be implemented
      }

      public List<FinancesBudget> readBudgetFromHistory() {
         var list = new List<FinancesBudget>();
         // to be implemented
         return list;
      }

      public void writeBudgetToHistory(List<FinancesBudget> list) {
         // to be implemented
      }

      // setters
      public void setFinancesUrl(string param) { financesUrl = param; }
   }
}
