using HackerCentral.Common;

namespace HackerCentral.Research {
   public class ResearchManager : Manager{
      private ResearchIO io;

      public ResearchManager() {
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }

      // setter methods
      public void setIO(ResearchIO param) { io = param; }
   }
}
