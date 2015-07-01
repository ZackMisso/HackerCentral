using System;

namespace HackerCentral.Finances {
   public class FinancesTransaction {
      private DateTime date;
      private string receiptID;
      private float amount;
      private int budgetType;
      private bool doneByCash;

      // getter methods
      public DateTime getDate() { return date; }
      public string getReceiptID() { return receiptID; }
      public float getAmount() { return amount; }
      public int getBudgetType() { return budgetType; }
      public bool getDoneByCash() { return doneByCash; }

      // setter methods
      public void setDate(DateTime param) { date = param; }
      public void setRecieptID(string param) { receiptID = param; }
      public void setAmount(float param) { amount = param; }
      public void setBudgetType(int param) { budgetType = param; }
      public void getDoneByCash(bool param) { doneByCash = param; }
   }
}
