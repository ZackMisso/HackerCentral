using HackerCentral.CodingProjects;

namespace HackerCentral.Common {
   public class GlobalManager {
      private CodingProjectsManager codingProjectsManager;

      public GlobalManager() {
         codingProjectsManager = new CodingProjectManager();
      }

      public void update() {
         // to be implement
      }

      // getter methods
      public CodingProjectsManager getCodingProjectManager() { return codingProjectsManager; }
   }
}
