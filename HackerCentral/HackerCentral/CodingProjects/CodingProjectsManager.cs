namespace HackerCentral.CodingProjects {
   public class CodingProjectsManager {
      private List<CodingProject> projects;
      private List<CodingProjectsTask> tasks;
      private List<CodingProjectsGoal> goals;
      private CodingProjectsIO io;

      public CodingProjectsManager() {
         io = new CodingProjects();
      }

      public void initialize() {
         projects = io.readCodingProjectsFromFile();
      }

      public void update() {
         // to be implemented
      }

      // getters
      public List<CodingProject> getProjects() { return projects; }

      // setters
      public void setProjects(List<CodingProject> param) { projects = param; }
      public void setIO(CodingProjectsIO param) { io = param; }
   }
}
