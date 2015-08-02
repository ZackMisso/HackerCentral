using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Finances {
   public class FinancesIO : IO{
      private FinancesManager manager;
      private string financesUrl;

      public FinancesIO(FinancesManager param,string url) {
         manager = param;
         financesUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(getTransactionsUrl())
            Directory.CreateDirectory(getTransactionsUrl());
         if (!Directory.Exists(getBudgetUrl())
            Directory.CreateDirectory(getBudgetUrl();
         if (!Directory.Exists(getHistoryUrl())
            Directory.CreateDirectory(getHistoryUrl());
         if (!Directory.Exists(getTransactionHistoryUrl())
            Directory.CreateDirectory(getTransactionHistoryUrl());
         if (!Directory.Exists(getBudgetHistoryUrl())
            Directory.CreateDirectory(getBudgetHistoryUrl());
      }

      private string getTransactionsUrl() { return financesUrl + "\\Transactions"; }
      private string getBudgetUrl() { return financesUrl + "\\Budget"; }
      private string getHistoryUrl() { return financesUrl + "\\History"; }
      private string getTransactionHistoryUrl() { return getHistoryUrl() + "\\Transactions"; }
      private string getBudgetHistoryUrl() { return getHistoryUrl() + "\\Budget"; }

      #region Transactions

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

      public void writeTransactionToFile(FinancesTransaction transaction) {
         // to be implemented
      }

      public void writeTransactionToHistory(FinancesTransaction transaction) {
         // to be implemented
      }

      #endregion

      #region Budgets

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

      public void writeBudgetToFile(FinancesBudget budget) {
         // to be implemented
      }

      public void writeBudgetToHistory(FinancesBudget budget) {
         // to be implemented
      }

      #endregion

      // setters
      public void setFinancesUrl(string param) { financesUrl = param; }
   }
}
