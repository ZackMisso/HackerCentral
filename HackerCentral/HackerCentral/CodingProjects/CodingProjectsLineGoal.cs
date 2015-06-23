namespace HackerCentral.CodingProjects {
   public class CodingProjectsLineGoal : CodingProjectsGoal{
      private int originalLineCount;
      private int goalLineCount;

      public override void updateGoal(object obj) {
         var project = (CodingProject)obj;
      }

      // getter methods
      public int getOriginalLineCount() { return originalLineCount; }
      public int getGoalLineCount() { return goalLineCount; }

      // setter methods
      public void setOriginalLineCount(int param) { originalLineCount = param; }
      public void setGoalLineCount(int param) { goalLineCount = param; }
   }
}
