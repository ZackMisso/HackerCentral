using System.Collections.Generic;

namespace HackerCentral.CodingProjects {
   public class CodingProject {
      private List<string> typesOfFiles;
      private List<Task> tasks;
      private string url;
      private string name;
      private int linesOfCode;

      public CodingProject(string val) {
         url = val;
      }

      public void update(CodingProjectsIO io) {
         // to be implemented
      }

      public void addTask(Task task) {
         tasks.add(task);
      }

      // getter methods
      public List<string> getTypesOfFiles() { return typesOfFiles; }
      public List<Task> getTasks() { return tasks; }
      public string getName() { return name; }
      public string getUrl() { return url; }
      public int getLinesOfCode() { return linesOfCode; }

      // setter methods
      public void setTypesOfFiles(List<string> param) { typesOfFiles = param; }
      public void setTasks(List<Task> param) { tasks = param; }
      public void setName(string param) { name = param; }
      public void setUrl(string param) { url = param; }
      public void setLinesOfCode(int param) { linesOfCode = param; }
   }
}
