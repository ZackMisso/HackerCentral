using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Research {
   public class ResearchManager : Manager{
      private List<ResearchReading> readings;
      private List<ResearchTask> tasks;
      private List<ResearchGoal> goals;
      private ResearchIO io;
      private int nextReadingID;
      private int nextTaskID;
      private int nextGoalID;

      public ResearchManager() {
         readings = new List<ResearchReading>();
         tasks = new List<ResearchTask>();
         goals = new List<ResearchGoal>();
      }

      public void initialize() {
         // read in IDs
         readings = io.readReadingsFromFiles();
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
      public List<ResearchReading> getReadings() { return readings; }
      public List<ResearchTask> getTasks() { return tasks; }
      public List<ResearchGoal> getGoals() { return goals; }
      public IO getIO() { return io; }
      public int getNextReadingID() { return nextReadingID; }
      public int getNextGoalID() { return nextGoalID; }
      public int getNextTaskID() { return nextTaskID; }

      // setter methods
      public void setReadings(List<ResearchReading> param) { readings = param; }
      public void setTasks(List<ResearchTask> param) { tasks = param; }
      public void setGoals(List<ResearchGoal> param) { goals = param; }
      public void setIO(ResearchIO param) { io = param; }
      public void setNextReadingID(int param) { nextReadingID = param; }
      public void setNextGoalID(int param) { nextGoalID = param; }
      public void setNextTaskID(int param) { nextTaskID = param; }
   }
}
