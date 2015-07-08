using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProject {
      private List<string> typesOfFiles;
      private List<CodingProjectsTask> tasks;
      private int projectGoal;
      private DateTime lastUpdate;
      private string url;
      private string name;
      private string description;
      private int linesOfCode;
      private int projectID;

      public CodingProject(string val) {
         typesOfFiles = new List<string>();
         tasks = new List<CodingProjectsTask>();
         projectGoal = -1;
         url = val;
         name = "";
         description = "";
         linesOfCode = 0;
         projectID = -1;
      }

      public void update(CodingProjectsIO io) {
         linesOfCode = getLinesInDirectory(url);
      }

      public int getLinesInDirectory(string path) {
         var directories = Directory.GetDirectories(path);
         var files = Directory.GetFiles(path);
         var count = 0;
         foreach (string directory in directories)
            count += getLinesInDirectory(directory);
         foreach (string file in files)
            if (typesOfFiles.Contains(Path.GetExtension(file)))
               count += File.ReadLines(file).Count();
         return count;
      }

      public void addTask(CodingProjectsTask task) {
         tasks.Add(task);
      }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(name);
         sb.Append(" " + url);
         sb.Append(" " + DateTime.UtcNow.ToString());
         sb.Append(" " + linesOfCode.ToString());
         sb.Append(" " + projectID.ToString());
         if (projectGoal != null)
            sb.Append(" " + projectGoal.ToString());
         else
            sb.Append(" -1");
         sb.Append(" " + tasks.Count);
         foreach (CodingProjectsTask task in tasks)
            sb.Append(" " + task.getTaskID());
         sb.Append(" " + typesOfFiles.Count);
         foreach (string ext in typesOfFiles)
            sb.Append(" " + ext);
         sb.Append(description);
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public List<string> getTypesOfFiles() { return typesOfFiles; }
      public List<CodingProjectsTask> getTasks() { return tasks; }
      public DateTime getLastUpdate() { return lastUpdate; }
      public int getProjectGoal() { return projectGoal; }
      public string getName() { return name; }
      public string getDescription() { return description; }
      public string getUrl() { return url; }
      public int getLinesOfCode() { return linesOfCode; }
      public int getProjectID() { return projectID; }

      // setter methods
      public void setTypesOfFiles(List<string> param) { typesOfFiles = param; }
      public void setTasks(List<CodingProjectsTask> param) { tasks = param; }
      public void setLastUpdate(DateTime param) { lastUpdate = param; }
      public void setProjectGoal(int param) { projectGoal = param; }
      public void setName(string param) { name = param; }
      public void setDescription(string param) { description = param; }
      public void setUrl(string param) { url = param; }
      public void setLinesOfCode(int param) { linesOfCode = param; }
      public void setProjectID(int param) { projectID = param; }
   }
}
