using HackerCentral.Common;

namespace HackerCentral.Settings {
   public class SettingsManager : Manager{
      private SettingsIO io;

      public SettingsManager() {
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }
   }
}
