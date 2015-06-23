using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProject {
      private List<string> typesOfFiles;
      private List<Task> tasks;
      private CodingProjectsGoal projectGoal;
      private string url;
      private string name;
      private string description;
      private int linesOfCode;
      private int projectID;

      public CodingProject(string val) {
         typesOfFiles = new List<string>();
         tasks = new List<Task>();
         projectGoal = null;
         url = val;
         name = "";
         description = "";
         linesOfCode = 0;
         projectID = -1;
      }

      public void update(CodingProjectsIO io) {
         // to be implemented
      }

      public void addTask(Task task) {
         tasks.Add(task);
      }

      // getter methods
      public List<string> getTypesOfFiles() { return typesOfFiles; }
      public List<Task> getTasks() { return tasks; }
      public CodingProjectsGoal getProjectGoal() { return projectGoal; }
      public string getName() { return name; }
      public string getDescription() { return description; }
      public string getUrl() { return url; }
      public int getLinesOfCode() { return linesOfCode; }
      public int getProjectID() { return projectID; }

      // setter methods
      public void setTypesOfFiles(List<string> param) { typesOfFiles = param; }
      public void setTasks(List<Task> param) { tasks = param; }
      public void setProjectGoal(CodingProjectsGoal param) { projectGoal = param; }
      public void setName(string param) { name = param; }
      public void setDescription(string param) { description = param; }
      public void setUrl(string param) { url = param; }
      public void setLinesOfCode(int param) { linesOfCode = param; }
      public void setProjectID(int param) { projectID = param; }
   }
}
