using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Finances {
   public class FinancesManager : Manager{
      private List<FinancesTransaction> transactions;
      private List<FinancesBudget> budgets;
      private FinancesIO io;
      private int nextTransactionID;
      private int nextBudgetID;

      public FinancesManager() {
         transactions = new List<FinancesTransaction>();
         budgets = new List<FinancesBudget>();
      }

      public void initialize() {
         // Read in IDs
         transactions = io.readTransactionsFromFiles();
         budgets = io.readBudgetFromFiles();
         match();
      }

      public void update() {
         // to be implemented
      }

      public void match() {
         // currently does nothing
      }

      // getter methods
      public List<FinancesTransaction> getTransactions() { return transactions; }
      public List<FinancesBudget> getBudgets() { return budgets; }
      public IO getIO() { return io; }
      public int getNextTransactionID() { return nextTransactionID; }
      public int getNextBudgetID() { return nextBudgetID; }

      // setter methods
      public void setTransactions(List<FinancesTransaction> param) { transaction = param; }
      public void setBudgets(List<FinancesBudget> param) { budgets = param; }
      public void setIO(FinancesIO param) { io = param; }
      public void setNextTransactionID(int param) { nextTransactionID = param; }
      public void setNextBudgetID(int param) { nextBudgetID = param; }
   }
}
