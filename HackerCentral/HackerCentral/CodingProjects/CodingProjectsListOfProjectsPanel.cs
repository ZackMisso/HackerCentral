using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsListOfProjectsPanel : CustomPanel{
      private CodingProjectsManager manager;
      private List<Label> projectDescriptionLabels;
      private List<Label> projectNameLabels;
      private List<Label> projectNumberOfLines;

      public CodingProjectsListOfProjectsPanel() {
         // to be implemented
      }

      // getter methods
      public CodingProjectsManager getManager() { return manager; }

      // setter methods
      public void setManager(CodingProjectsManager param) { manager = param; }
   }
}
