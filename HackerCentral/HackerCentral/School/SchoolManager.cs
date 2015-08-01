using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolManager : Manager{
      private List<SchoolAssignment> assignments;
      private List<SchoolClass> classes;
      private List<SchoolTask> tasks;
      private List<SchoolGoal> goals;
      private SchoolIO io;
      private int nextAssignmentID;
      private int nextClassID;
      private int nextTaskID;
      private int nextGoalID;

      public SchoolManager() {
         assignments = new List<SchoolAssignment>();
         classes = new List<SchoolClass>();
         tasks = new List<SchoolTask>();
         goals = new List<SchoolGoal>();
      }

      public void initialize() {
         // Read in IDs
         assignments = io.readAssignmentsFromFiles();
         classes = io.readClassesFromFiles();
         tasks = io.readTasksFromFiles();
         goals = io.readGoalsFromFiles();
         match();
      }

      public void match() {
         // implement mixing
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<SchoolClass> getClasses() { return classes; }
      public List<SchoolTask> getTasks() { return tasks; }
      public List<SchoolGoal> getGoals() { return goals; }
      public IO getIO() { return io; }
      public int getNextAssingnmentID() { return nextAssignmentID; }
      public int getNextClassID() { return nextClassID; }
      public int getNextTaskID() { return nextTaskID; }
      public int getNextGoalID() { return nextGoalID; }

      // setter methods
      public void setClasses(List<SchoolClass> param) { classes = param; }
      public void setTasks(List<SchoolTask> param) { tasks = param; }
      public void setGoals(List<SchoolGoal> param) { goals = param; }
      public void setIO(SchoolIO param) { io = param; }
      public void setNextAssingmentID(int param) { nextAssignmentID = param; }
      public void setNextClassID(int param) { nextClassID = param; }
      public void setNextTaskID(int param) { nextTaskID = param; }
      public void setNextGoalID(int param) { nextGoalID = param; }
   }
}
