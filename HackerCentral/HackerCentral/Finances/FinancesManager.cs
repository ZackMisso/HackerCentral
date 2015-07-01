using HackerCentral.Common;

namespace HackerCentral.Finances {
   public class FinancesManager : Manager{
      private FinancesIO io;

      public FinancesManager() {
         // to be implemented
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }

      // setter methods
      public void setIO(FinancesIO param) { io = param; }
   }
}
