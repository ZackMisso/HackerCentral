using HackerCentral.Common;

namespace HackerCentral.Behavioral {
   public class BehavioralManager : Manager{
      private BehavioralIO io;

      public BehavioralManager() {
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }

      // setter methods
      public void setIO(BehavioralIO param) { io = param; }
   }
}
