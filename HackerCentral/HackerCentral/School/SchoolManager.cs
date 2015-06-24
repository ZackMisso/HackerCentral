using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolManager : Manager{
      private SchoolIO io;

      public SchoolManager() {
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }

      // setter methods
      public void setIO(SchoolIO param) { io = param; }
   }
}
