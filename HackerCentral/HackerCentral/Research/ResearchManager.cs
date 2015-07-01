using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Research {
   public class ResearchManager : Manager{
      private List<ResearchTask> tasks;
      private List<ResearchGoal> goals;
      private ResearchIO io;

      public ResearchManager() {
         tasks = new List<ResearchTask>();
         goals = new List<ResearchGoal>();
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<ResearchTask> getTasks() { return tasks; }
      public List<ResearchGoal> getGoals() { return goals; }
      public IO getIO() { return io; }

      // setter methods
      public void setTasks(List<ResearchTask> param) { tasks = param; }
      public void setGoals(List<ResearchGoal> param) { goals = param; }
      public void setIO(ResearchIO param) { io = param; }
   }
}
