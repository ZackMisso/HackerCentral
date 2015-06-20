namespace HackerCentral.CodingProjects {
   public class CodingProjectsMasterGoal : CodingProjectsGoal{
      public CodingProjectsMasterGoal()
         : base() {
         // to be implemented
      }

      public override void updateGoal(object obj) {
         var project = (CodingProject)obj;
      }
   }
}
