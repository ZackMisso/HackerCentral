using System.Text;

namespace HackerCentral.Fitness {
   public class FitnessExerciseGoal {
      private FitnessExercise exercise;
      private int exerciseID;
      private int totalReps;
      private int dailyReps;
      private bool perDay;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public FitnessExercise getExercise() { return exercise; }
      public int getExerciseID() { return exerciseID; }
      public int getTotalReps() { return totalReps; }
      public int getDailyReps() { return dailyReps; }
      public bool getPerDay() { return perDay; }

      // setter methods
      public void setExercise(FitnessExercise param) { exercise = param; }
      public void setExerciseID(int param) { exerciseID = param; }
      public void setTotalReps(int param) { totalReps = param; }
      public void setDailyReps(int param) { dailyReps = param; }
      public void setPerDay(bool param) { perDay = param; }
   }
}
