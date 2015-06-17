using HackerCentral.CodingProjects;

namespace HackerCentral.Common {
   public class GlobalManager : Manager{
      private CodingProjectsManager codingProjectsManager;

      public GlobalManager() {
         codingProjectsManager = new CodingProjectsManager();
      }

      public void initializeAllIO(GlobalIO io) {
         // to be implemented
      }

      public void update() {
         codingProjectsManager.update();
      }

      public IO getIO() {
         return null;
      }

      // getter methods
      public CodingProjectsManager getCodingProjectsManager() { return codingProjectsManager; }
   }
}
