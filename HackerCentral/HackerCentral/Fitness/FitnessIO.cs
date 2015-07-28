using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessIO : IO{
      private FitnessManager manager;
      private string fitnessUrl;

      public FitnessIO(FitnessManager param,string url) {
         manager = param;
         fitnessUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(fitnessUrl + "\\Exercises"))
            Directory.CreateDirectory(fitnessUrl + "\\Exercises");
         if (!Directory.Exists(fitnessUrl + "\\Goals"))
            Directory.CreateDirectory(fitnessUrl + "\\Goals");
         if (!Directory.Exists(fitnessUrl + "\\History"))
            Directory.CreateDirectory(fitnessUrl + "\\History");
         if (!Directory.Exists(fitnessUrl + "\\History\\Exercises"))
            Directory.CreateDirectory(fitnessUrl + "\\History\\Exerciess");
         if (!Directory.Exists(fitnessUrl + "\\History\\Goals"))
            Directory.CreateDirectory(fitnessUrl + "\\History\\Goals");
      }

      public List<FitnessExercise> readExcercisesFromFiles() {
         var list = new List<FitnessExercise>();
         // to be implemented
         return list;
      }

      public void writeExercisesToFiles(List<FitnessExercise> list) {
         // to be implemented
      }

      public List<FitnessExercise> readExercisesFromHistory() {
         var list = new List<FitnessExercise>();
         // to be implemented
         return list;
      }

      public void writeExercisesToHistory(List<FitnessExercise> list) {
         // to be implemented
      }

      public List<FitnessExerciseGoal> readExerciseGoalFromFiles() {
         var list = new List<FitnessExerciseGoal>();
         // to be implemented
         return list;
      }

      public void writeExerciseGoalsToFiles(List<FitnessExerciseGoal> list) {
         // to be implemented
      }

      public List<FitnessExerciseGoal> readExerciseGoalFromHistory() {
         var list = new List<FitnessExerciseGoal>();
         // to be implemented
         return list;
      }

      public void writeExerciseGoalToHistory(List<FitnessExerciseGoal> list) {
         // to be implemented
      }

      // setters
      public void setFitnessUrl(string param) { fitnessUrl = param; }
   }
}
