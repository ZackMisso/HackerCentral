using System.IO;
using HackerCentral.Art;
using HackerCentral.Behavioral;
using HackerCentral.CodingProjects;
using HackerCentral.Finances;
using HackerCentral.Fitness;
using HackerCentral.Music;
using HackerCentral.Research;
using HackerCentral.School;

namespace HackerCentral.Common {
   public class GlobalIO : IO{
      private string globalUrl;
      private ArtIO artIO;
      private BehavioralIO behavioralIO;
      private CodingProjectsIO codingProjectsIO;
      private FinancesIO financesIO;
      private FitnessIO fitnessIO;
      private MusicIO musicIO;
      private ResearchIO researchIO;
      private SchoolIO schoolIO;

      public GlobalIO(string url) {
         globalUrl = url; // url to project
         loadProjectData();
      }

      public void loadProjectData() {
         if (File.Exists(globalUrl + "\\GlobalIO.txt"))
            loadSubsystemIO();
         else {
            createHierarchyStructure();
            loadSubsystemIO();
         }
      }

      private void loadSubsystemIO() {
         artIO = new ArtIO(globalUrl + "\\Art");
         behavioralIO = new BehavioralIO(globalUrl + "\\Behavioral");
         codingProjectsIO = new CodingProjectsIO(globalUrl + "\\CodingProjects");
         financesIO = new FinancesIO(globalUrl + "\\Finances");
         fitnessIO = new FitnessIO(globalUrl + "\\Fitness");
         musicIO = new MusicIO(globalUrl + "\\Music");
         researchIO = new ResearchIO(globalUrl + "\\Research");
         schoolIO = new SchoolIO(globalUrl + "\\School");
      }

      private void createHierarchyStructure() {
         if (!Directory.Exists(globalUrl + "\\Art"))
            Directory.CreateDirectory(globalUrl + "\\Art");
         if (!Directory.Exists(globalUrl + "\\Behavioral"))
            Directory.CreateDirectory(globalUrl + "\\Behavioral");
         if (!Directory.Exists(globalUrl + "\\CodingProjects"))
            Directory.CreateDirectory(globalUrl + "\\CodingProjects");
         if (!Directory.Exists(globalUrl + "\\Finances"))
            Directory.CreateDirectory(globalUrl + "\\Finances");
         if (!Directory.Exists(globalUrl + "\\Fitness"))
            Directory.CreateDirectory(globalUrl + "\\Fitness");
         if (!Directory.Exists(globalUrl + "\\Music"))
            Directory.CreateDirectory(globalUrl + "\\Music");
         if (!Directory.Exists(globalUrl + "\\Research"))
            Directory.CreateDirectory(globalUrl + "\\Research");
         if (!Directory.Exists(globalUrl + "\\School"))
            Directory.CreateDirectory(globalUrl + "\\School");
      }

      // getter methods
      public ArtIO getArtIO() { return artIO; }
      public BehavioralIO getBehavioralIO() { return behavioralIO; }
      public CodingProjectsIO getCodingProjectsIO() { return codingProjectsIO; }
      public FinancesIO getFinancesIO() { return financesIO; }
      public FitnessIO getFitnessIO() { return fitnessIO; }
      public MusicIO getMusicIO() { return musicIO; }
      public ResearchIO getResearchIO() { return researchIO; }
      public SchoolIO getSchoolIO() { return schoolIO; }
   }
}
