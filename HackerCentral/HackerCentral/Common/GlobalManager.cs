using HackerCentral.CodingProjects;

namespace HackerCentral.Common {
   public class GlobalManager : Manager{
      private CodingProjectsManager codingProjectsManager;

      public GlobalManager() {
         codingProjectsManager = new CodingProjectManager();
      }

      public void update() {
         codingProjectsManager.update();
      }

      // getter methods
      public CodingProjectsManager getCodingProjectManager() { return codingProjectsManager; }
   }
}
