using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicManager : Manager{
      private MusicIO io;

      public MusicManager(){
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }

      // setter methods
      public void setIO(MusicIO param) { io = param; }
   }
}
