using HackerCentral.Art;
using HackerCentral.Behavioral;
using HackerCentral.CodingProjects;
using HackerCentral.Finances;
using HackerCentral.Fitness;
using HackerCentral.Music;
using HackerCentral.Research;
using HackerCentral.School;

namespace HackerCentral.Common {
   public class GlobalManager : Manager{
      private ArtManager artManager;
      private BehavioralManager behavioralManager;
      private CodingProjectsManager codingProjectsManager;
      private FinancesManager financesManager;
      private FitnessManager fitnessManager;
      private MusicManager musicManager;
      private ResearchManager researchManager;
      private SchoolManager schoolManager;
      private static int taskID;

      public GlobalManager() {
         artManager = new ArtManager();
         behavioralManager = new BehavioralManager();
         codingProjectsManager = new CodingProjectsManager();
         financesManager = new FinancesManager();
         fitnessManager = new FitnessManager();
         musicManager = new MusicManager();
         researchManager = new ResearchManager();
         schoolManager = new SchoolManager();
         taskID = 0;
      }

      public void initializeAllIO(GlobalIO io) {
         artManager.setIO(io.getArtIO());
         behavioralManager.setIO(io.getBehavioralIO());
         codingProjectsManager.setIO(io.getCodingProjectsIO());
         financesManager.setIO(io.getFinancesIO());
         fitnessManager.setIO(io.getFitnessIO());
         musicManager.setIO(io.getMusicIO());
         researchManager.setIO(io.getResearchIO());
         schoolManager.setIO(io.getSchoolIO());
      }

      public void update() {
         artManager.update();
         behavioralManager.update();
         codingProjectsManager.update();
         financesManager.update();C:\Users\zmisso\Documents\HackerCentral\HackerCentral\HackerCentral\Common\GlobalIO.cs
         fitnessManager.update();
         musicManager.update();
         researchManager.update();
         schoolManager.update();
      }

      public static int getNextTaskID() {
         return taskID++;
      }

      public IO getIO() {
         return null;
      }

      // getter methods
      public ArtManager getArtManager() { return artManager; }
      public BehavioralManager getBehavioralManager() { return behavioralManager; }
      public CodingProjectsManager getCodingProjectsManager() { return codingProjectsManager; }
      public FinancesManager getFinancesManager() { return financesManager; }
      public FitnessManager getFitnessManager() { return fitnessManager; }
      public MusicManager getMusicManager() { return musicManager; }
      public ResearchManager getResearchManager() { return researchManager; }
      public SchoolManager getSchoolManager() { return schoolManager; }
   }
}
