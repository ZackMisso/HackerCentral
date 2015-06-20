using HackerCentral.CodingProjects;

namespace HackerCentral.Common {
   public class GlobalManager : Manager{
      private CodingProjectsManager codingProjectsManager;
      private static int taskID;

      public GlobalManager() {
         codingProjectsManager = new CodingProjectsManager();
         taskID = 0;
      }

      public void initializeAllIO(GlobalIO io) {
         // to be implemented
      }

      public void update() {
         codingProjectsManager.update();
      }

      public static int getNextTaskID() {
         return taskID++;
      }

      public IO getIO() {
         return null;
      }

      // getter methods
      public CodingProjectsManager getCodingProjectsManager() { return codingProjectsManager; }
   }
}
