namespace HackerCentral.Fitness {
   public class FitnessTask {
      private FitnessExercise exercise;
      private int exerciseID;
      private int reps;
      private bool daily;
      private bool weekly;
      private bool monthly;

      // getter methods
      public FitnessExercise getFitnessExercise() { return exercise; }
      public int getExerciseID() { return exerciseID; }
      public int getReps() { return reps; }
      public bool getDaily() { return daily; }
      public bool getMonthly() { return monthly; }
      public bool getWeekly() { return weekly; }

      // setter methods
      public void setFitnessExercise(FitnessExercise param){exercise = param;}
      public void setExerciseID(int param){exerciseID = param;}
      public void setReps(int param) { reps = param; }
      public void setDaily(bool param) { daily = param; }
      public void setWeekly(bool param) { weekly = param; }
      public void setMonthly(bool param) { monthly = param; }
   }
}
