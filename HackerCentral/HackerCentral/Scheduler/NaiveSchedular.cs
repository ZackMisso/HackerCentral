namespace HackerCentral.Scheduler {
   // TO BE IMPLEMENTED FOR VERSION 0.2.0

   public class NaiveSchedular {
      private GlobalManager reference;

      public NaiveSchedular(GlobalManager param) {
         reference = param;
      }

      public Task chooseRandomTask() {
         // to be implemented
         return null;
      }

      private Task chooseArtTask() {
         var manager = reference.getArtManager();
         // to be implemented
         return null;
      }

      private Task chooseBehavioralTask() {
         var manager = reference.getBehavioralManager();
         // to be implemented
         return null;
      }

      private Task chooseCodingProjectsTask() {
         var manager = reference.getCodingProjectsManager();
         // to be implemented
         return null;
      }

      private Task chooseFitnessTask() {
         var manager = reference.getFinancesManager();
         // to be implemented
         return null;
      }

      private Task chooseMusicTask() {
         var manager = reference.getMusicManager();
         // to be implemented
         return null;
      }

      private Task chooseResearchTask() {
         var manager = reference.getResearchManager();
         // to be implemented
         return null;
      }

      private Task chooseSchoolTask() {
         var manager = reference.getSchoolManager();
         // to be implemented
         return null;
      }
   }
}
