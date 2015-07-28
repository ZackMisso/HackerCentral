using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessManager : Manager{
      private List<FitnessExercise> exercises;
      private List<FitnessExerciseGoal> exerciseGoals;
      private FitnessIO io;

      public FitnessManager() {
         exercises = new List<FitnessExercise>();
         exerciseGoals = new List<FitnessExerciseGoal>();
      }

      public void update() {
         // to be implemented
      }

      public void initialize() {
         // to be implemented
      }

      // getter methods
      public List<FitnessExercise> getExercises() { return exercises; }
      public List<FitnessExerciseGoal> getExerciseGoals() { return exerciseGoals; }
      public IO getIO() { return io; }

      // setter methods
      public void setExercises(List<FitnessExercise> param) { exercises = param; }
      public void setExerciseGoals(List<FitnessExerciseGoal> param) { exerciseGoals = param; }
      public void setIO(FitnessIO param) { io = param; }
   }
}
