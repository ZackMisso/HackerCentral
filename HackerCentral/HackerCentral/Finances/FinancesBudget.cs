﻿using System;
using System.Collections.Generic;

namespace HackerCentral.Finances {
   public class FinancesBudget { // monthly budget
      private Dictionary<string, float> budgetTypes;
      private DateTime startDate;
      private DateTime endDate;

      public FinancesBudget() {
         budgetTypes = new Dictionary<string, float>();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public Dictionary<string, float> getBudgetTypes() { return budgetTypes; }
      public DateTime getStartDate() { return startDate; }
      public DateTime getEndDate() { return endDate; }

      // setter methods
      public void setBudgetTypes(Dictionary<string, float> param) { budgetTypes = param; }
      public void setStartDate(DateTime param) { startDate = param; }
      public void setEndDate(DateTime param) { endDate = param; }
   }
}
