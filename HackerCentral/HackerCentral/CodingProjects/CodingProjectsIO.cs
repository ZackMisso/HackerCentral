using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsIO : IO{
      private string codingProjectsUrl;

      public CodingProjectsIO(string url) {
         codingProjectsUrl = url;
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(codingProjectsUrl + "\\Tasks"))
            Directory.CreateDirectory(codingProjectsUrl + "\\Tasks");
         if (!Directory.Exists(codingProjectsUrl + "\\Goals"))
            Directory.CreateDirectory(codingProjectsUrl + "\\Goals");
         if (!Directory.Exists(codingProjectsUrl + "\\Projects"))
            Directory.CreateDirectory(codingProjectsUrl + "\\Projects");
         if (!Directory.Exists(codingProjectsUrl + "\\History"))
            Directory.CreateDirectory(codingProjectsUrl + "\\History");
         if (!Directory.Exists(codingProjectsUrl + "\\History\\Tasks"))
            Directory.CreateDirectory(codingProjectsUrl + "\\History\\Tasks");
         if (!Directory.Exists(codingProjectsUrl + "\\History\\Goals"))
            Directory.CreateDirectory(codingProjectsUrl + "\\History\\Goals");
         if (!Directory.Exists(codingProjectsUrl + "\\History\\Projects"))
            Directory.CreateDirectory(codingProjectsUrl + "\\History\\Projects");
      }

      public List<CodingProject> readCodingProjectsFromFiles(){
         var list = new List<CodingProject>();
         var files = Directory.GetFiles(codingProjectsUrl + "\\Projects");
         for(string file in files){
            var reader = new StreamReader(file);
            var project = new CodingProject();
            string line;
            while(line = reader.ReadLine() != null){
               string[] contents = line.Split(' ');
               // to be implemented
            }
            list.Add(project);
            reader.Close();
         }
         return list;
      }

      public void writeCodingProjectsToFiles(List<CodingProject> list) {
         foreach (CodingProject project in list) {
            var filePath = codingProjectsUrl + "\\Projects\\" + project.getName() + ".txt";
            File.WriteAllText(filePath, project.ToString());
         }
      }

      public List<CodingProjectsTask> readTasksFromFile(){
         var list = new List<CodingProjectsTask>();
         // to be impelemnted
         return list;
      }

      public void writeTasksToFiles(List<CodingProjectsTask> list) {
         // to be implemented
      }

      public List<CodingProjectsTask> readFinishedTasksFromFile(){
         var list = new List<CodingProjectsTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToHistory(List<CodingProjectsTask> list) {
         // to be implemented
      }

      public List<CodingProjectsGoal> readGoalsFromFile(){
         var list = new List<CodingProjectsGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToFile(List<CodingProjectsGoal> list) {
         // to be implemetned
      }

      public List<CodingProjectsGoal> readFinishedGoalsFromFile(){
         var list = new List<CodingProjectsGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<CodingProjectsGoal> list) {
         // to be implemented
      }

      public int getLinesOfCodeForProject(string url, List<string> typesOfFiles){
         var lines = 0;
         // to be implemented
         return lines;
      }

      // setter methods
      public void setCodingProjectsUrl(string param) { codingProjectsUrl = param; }
   }
}
