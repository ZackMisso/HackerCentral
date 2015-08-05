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
         foreach (FinancesTransaction transaction in list) {
            var filePath = getTransactionUrl() + transaction.getTransactionID().ToString() + ".txt";
            File.WriteAllText(filePath, transaction.ToString());
         }
      }

      public List<FinancesTransaction> readTransactionsFromHistory() {
         var list = new List<FinancesTransaction>();
         // to be implemented
         return list;
      }

      public void writeTransactionsToHistory(List<FinancesTransaction> list) {
         foreach (FinancesTransaction transaction in list) {
            var filePath = getTransactionHistoryUrl() + transaction.getTransactionID().ToString() + ".txt";
            File.WriteAllText(filePath, transaction.ToString());
         }
      }

      public void writeTransactionToFile(FinancesTransaction transaction) {
         var filePath = getTransactionUrl() + transaction.getTransactionID().ToString() + ".txt";
         File.WriteAllText(filePath, transaction.ToString());
      }

      public void writeTransactionToHistory(FinancesTransaction transaction) {
         var filePath = getTransactionHistoryUrl() + transaction.getTransactionID().ToString() + ".txt";
         File.WriteAllText(filePath, transaction.ToString());
      }

      #endregion

      #region Budgets

      public List<FinancesBudget> readBudgetFromFiles() {
         var list = new List<FinancesBudget>();
         // to be implemented
         return list;
      }

      public void writeBudgetToFiles(List<FinancesBudget> list) {
         foreach (FinancesBudget budget in list) {
            var filePath = getBudgetUrl() + budget.getBudgetID().ToString() + ".txt";
            File.WriteAllText(filePath, budget.ToString());
         }
      }

      public List<FinancesBudget> readBudgetFromHistory() {
         var list = new List<FinancesBudget>();
         // to be implemented
         return list;
      }

      public void writeBudgetToHistory(List<FinancesBudget> list) {
         foreach (FinancesBudget budget in list) {
            var filePath = getBudgetHistoryUrl() + budget.getBudgetID().ToString() + ".txt";
            File.WriteAllText(filePath, budget.ToString());
         }
      }

      public void writeBudgetToFile(FinancesBudget budget) {
         var filePath = getBudgetUrl() + budget.getBudgetID().ToString() + ".txt";
         File.WriteAllText(filePath, budget.ToString());
      }

      public void writeBudgetToHistory(FinancesBudget budget) {
         var filePath = getBudgetHistoryUrl() + budget.getBudgetID().ToString() + ".txt";
         File.WriteAllText(filePath, budget.ToString());
      }

      #endregion

      // setters
      public void setFinancesUrl(string param) { financesUrl = param; }
   }
}
