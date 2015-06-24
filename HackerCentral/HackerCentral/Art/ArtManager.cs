using HackerCentral.Common;

namespace HackerCentral.Art {
   public class ArtManager : Manager{
      private ArtIO io;

      public ArtManager() {
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }

      // setter methods
      public void setIO(ArtIO param) { io = param; }
   }
}
