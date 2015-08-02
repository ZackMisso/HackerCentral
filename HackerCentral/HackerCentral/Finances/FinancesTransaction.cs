using System;
using System.Text;

namespace HackerCentral.Finances {
   public class FinancesTransaction {
      private DateTime date;
      private string receiptID;
      private float amount;
      private int budgetType;
      private int transactionID;
      private bool doneByCash;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(transactionID.ToString() + "^");
         sb.Append(budgetType.ToString() + "^");
         sb.Append(recieptID + "^");
         sb.Append(amount.ToString() + "^");
         sb.Append(date.ToString("MM/dd/yyyy") + "^");
         sb.Append(doneByCash + "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public DateTime getDate() { return date; }
      public string getReceiptID() { return receiptID; }
      public float getAmount() { return amount; }
      public int getBudgetType() { return budgetType; }
      public int getTransactionID() { return transactionID; }
      public bool getDoneByCash() { return doneByCash; }

      // setter methods
      public void setDate(DateTime param) { date = param; }
      public void setRecieptID(string param) { receiptID = param; }
      public void setAmount(float param) { amount = param; }
      public void setBudgetType(int param) { budgetType = param; }
      public void setTransactionID(int param) { transactionID = param; }
      public void getDoneByCash(bool param) { doneByCash = param; }
   }
}
