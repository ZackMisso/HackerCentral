using System;
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
         var files = Directory.GetFiles(GetTransactionsUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var transaction = new FinancesTransaction();
               transaction.setTransactionID(Convert.ToInt32(contents[0]));
               transaction.setBudgetType(Convert.ToInt32(contents[1]));
               transaction.setRecieptID(Convert.ToInt32(contents[2]));
               transaction.setAmount((float)Convert.ToDouble(contents[3]));
               var date = contents[4];
               // create date
               transaction.setDoneByCash(contents[5].Equals("true"));
               list.Add(transaction);
            }
         }
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
         var files = Directory.GetFiles(getTransactionHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var transaction = new FinancesTransaction();
               transaction.setTransactionID(Convert.ToInt32(contents[0]));
               transaction.setBudgetType(Convert.ToInt32(contents[1]));
               transaction.setRecieptID(Convert.ToInt32(contents[2]));
               transaction.setAmount((float)Convert.ToDouble(contents[3]));
               var date = contents[4];
               // create date
               transaction.setDoneByCash(contents[5].Equals("true"));
               list.Add(transaction);
            }
         }
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
         var files = Directory.GetFiles(getBudgetUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var budget = new FinancesBudget();
               budget.setBudgetId(Convert.ToInt32(contents[0]));
               var startDate = contents[1];
               // create startDate
               var endDate = contents[2];
               // create endDate
               var types = Convert.ToInt32(contents[3]);
               var itr = 4;
               for (var i = 0; i < types; i++) {
                  var key = contents[itr++];
                  var val = (float)Convert.ToDouble(contents[itr++]);
                  budget.getBudgetTypes().Add(key, value);
               }
               list.Add(budget);
            }
         }
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
         var files = Directory.GetFiles(getBudgetHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var budget = new FinancesBudget();
               budget.setBudgetId(Convert.ToInt32(contents[0]));
               var startDate = contents[1];
               // create startDate
               var endDate = contents[2];
               // create endDate
               var types = Convert.ToInt32(contents[3]);
               var itr = 4;
               for (var i = 0; i < types; i++) {
                  var key = contents[itr++];
                  var val = (float)Convert.ToDouble(contents[itr++]);
                  budget.getBudgetTypes().Add(key, value);
               }
               list.Add(budget);
            }
         }
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

      #region MetaData

      public void checkFinancesSaveFile() {
         // To be implemented
         //if (!File.Exists(codingProjectsUrl + "\\meta.txt"))
         //   makeCodingProjectsSaveFile();
         //readCodingProjectsSaveFile();
      }

      public void makeFinancesSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //File.WriteAllText(filePath, "0\n0\n0\n");
      }

      public void writeFinancesSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //string str = manager.getNextProjectID() + "\n";
         //str += manager.getNextTaskID() + "\n";
         //str += manager.getNextGoalID() + "\n";
         //File.WriteAllText(filePath, str);
      }

      public void readFinancesSaveFile() {
         // to be implemented
         //var reader = new StreamReader(codingProjectsUrl + "\\meta.txt");
         //manager.setNextProjectID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextTaskID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextGoalID(Convert.ToInt32(reader.ReadLine()));
      }

      #endregion

      // setters
      public void setFinancesUrl(string param) { financesUrl = param; }
   }
}
