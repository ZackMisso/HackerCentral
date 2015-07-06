namespace HackerCentral.Fitness {
   public class FitnessExercise {
      private FitnessExerciseGoal goal;
      private string name;
      private int totalReps;
      private bool hasGoal;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }
      
      // getter methods
      public FitnessExerciseGoal getGoal() { return goal; }
      public string getName() { return name; }
      public int getTotalReps() { return totalReps; }
      public bool getHasGoal() { return hasGoal; }

      // setter methods
      public void setGoal(FitnessExerciseGoal param) { goal = param; }
      public void setName(string param) { name = param; }
      public void setTotalReps(int param) { totalReps = param; }
      public void setHasGoal(bool param) { hasGoal = param; }
   }
}
