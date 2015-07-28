using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolManager : Manager{
      private List<SchoolClass> classes;
      private List<SchoolTask> tasks;
      private List<SchoolGoal> goals;
      private SchoolIO io;

      public SchoolManager() {
         classes = new List<SchoolClass>();
         tasks = new List<SchoolTask>();
         goals = new List<SchoolGoal>();
      }

      public void initialize() {
         // to be implemented
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<SchoolClass> getClasses() { return classes; }
      public List<SchoolTask> getTasks() { return tasks; }
      public List<SchoolGoal> getGoals() { return goals; }
      public IO getIO() { return io; }

      // setter methods
      public void setClasses(List<SchoolClass> param) { classes = param; }
      public void setTasks(List<SchoolTask> param) { tasks = param; }
      public void setGoals(List<SchoolGoal> param) { goals = param; }
      public void setIO(SchoolIO param) { io = param; }
   }
}
