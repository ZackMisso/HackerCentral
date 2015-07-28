using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Finances {
   public class FinancesManager : Manager{
      private List<FinancesTransaction> transactions;
      private List<FinancesBudget> budgets;
      private FinancesIO io;

      public FinancesManager() {
         transactions = new List<FinancesTransaction>();
         budgets = new List<FinancesBudget>();
      }

      public void initialize() {
         // to be implemented
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<FinancesTransaction> getTransactions() { return transactions; }
      public List<FinancesBudget> getBudgets() { return budgets; }
      public IO getIO() { return io; }

      // setter methods
      public void setTransactions(List<FinancesTransaction> param) { transaction = param; }
      public void setBudgets(List<FinancesBudget> param) { budgets = param; }
      public void setIO(FinancesIO param) { io = param; }
   }
}
