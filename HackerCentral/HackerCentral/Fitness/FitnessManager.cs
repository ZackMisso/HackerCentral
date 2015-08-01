using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessManager : Manager{
      private List<FitnessExercise> exercises;
      private List<FitnessExerciseGoal> exerciseGoals;
      private List<FitnessTask> tasks
      private FitnessIO io;
      private int nextExerciseID;
      private int nextExerciseGoalID;

      public FitnessManager() {
         exercises = new List<FitnessExercise>();
         exerciseGoals = new List<FitnessExerciseGoal>();
         tasks = new List<FitnessTask>();
      }

      public void update() {
         // to be implemented
      }

      public void initialize() {
         // Read in IDs
         exercises = io.readExcercisesFromFiles();
         exerciseGoals = io.readExerciseGoalFromFiles();
         tasks = io.readTasksFromFiles();
         match();
      }

      public void match() {
         // implement mixing
      }

      // getter methods
      public List<FitnessExercise> getExercises() { return exercises; }
      public List<FitnessExerciseGoal> getExerciseGoals() { return exerciseGoals; }
      public List<FitnessTask> getTasks() { return tasks; }
      public IO getIO() { return io; }
      public int getNextExerciseID() { return nextExerciseID; }
      public int getNextExerciseGoalID() { return nextExerciseGoalID; }

      // setter methods
      public void setExercises(List<FitnessExercise> param) { exercises = param; }
      public void setExerciseGoals(List<FitnessExerciseGoal> param) { exerciseGoals = param; }
      public void setTasks(List<FitnessTask> param) { tasks = param; }
      public void setIO(FitnessIO param) { io = param; }
      public void setNextExerciseID(int param) { nextExerciseID = param; }
      public void setNextExerciseGoalID(int param) { nextExerciseGoalID = param; }
   }
}
