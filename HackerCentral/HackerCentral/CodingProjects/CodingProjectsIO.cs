using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using HackerCentral.Common;
using HackerCentral.Common.Enum;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsIO : IO{
      private CodingProjectsManager manager;
      private string codingProjectsUrl;

      public CodingProjectsIO(CodingProjectsManager param,string url) {
         manager = param;
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
         foreach(string file in files){
            var reader = new StreamReader(file);
            var project = new CodingProject(file);
            string line;
            while((line = reader.ReadLine()) != null){
               var contents = line.Split(' ');
               var index = 0;
               project.setName(contents[index++]);
               project.setUrl(contents[index++]);
               // read last update here //
               //project.
               index++;
               index++;
               index++;
               project.setLastUpdate(new DateTime(1,1,1));
               ///////////////////////////
               project.setLinesOfCode(Convert.ToInt32(contents[index++]));
               project.setProjectID(Convert.ToInt32(contents[index++]));
               project.setProjectGoal(Convert.ToInt32(contents[index++]));
               int numberOfTasks = Convert.ToInt32(contents[index++]);
               for(int i = 0; i < numberOfTasks; i++){
                  // to be implemented
                  index++;
               }
               int numOfExtensions = Convert.ToInt32(contents[index++]);
               List<string> fileTypes = new List<string>();
               for(int i = 0; i < numOfExtensions; i++)
                  fileTypes.Add(contents[index++]);
               project.setTypesOfFiles(fileTypes);
               var sb = new StringBuilder();
               for(int i = index; i < contents.Length; i++)
                  sb.Append(contents[i] + " ");
               //sb.Append("");
               project.setDescription(sb.ToString());
               list.Add(project);
            }
            //list.Add(project);
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

      public void writeCodingProjectsToHistory(List<CodingProject> list) {
         foreach (CodingProject project in list) {
            var filePath = codingProjectsUrl + "\\History\\Projects\\" + project.getName() + ".txt";
            using (StreamWriter sw = File.AppendText(filePath))
               sw.WriteLine(project.ToString());
         }
      }

      public void writeCodingProjectToFile(CodingProject project) {
         var filePath = codingProjectsUrl + "\\Projects\\" + project.getName() + ".txt";
         File.WriteAllText(filePath, project.ToString());
      }

      public void writeCodingProjectToHistory(CodingProject project) {
         var filePath = codingProjectsUrl + "\\History\\Projects\\" + project.getName() + ".txt";
         using (StreamWriter sw = File.AppendText(filePath))
            sw.WriteLine(project.ToString());
      }

      public List<CodingProjectsTask> readTasksFromFiles(){
         var list = new List<CodingProjectsTask>();
         var files = Directory.GetFiles(codingProjectsUrl + "\\Tasks");
         foreach (string file in files) {
            var reader = new StreamReader(file);
            var task new CodingProjectsTask();
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               task.setName(contents[0]);
               task.setTaskID(Convert.ToInt32(contents[1]));
               task.setEffort(Convert.ToInt32(contents[2]));
               var status = contents[3];
               if(status.Equals("InProgress"))
                  task.setStatus(TaskStatusEnum.InProgress);
               if(status.Equals("ToDo"))
                  task.setStatus(TaskStatusEnum.ToDo);
               if(status.Equals("Failed"))
                  task.setStatus(TaskStatusEnum.Failed);
               if(status.Equals("Done"))
                  task.setStatus(TaskStatusEnum.Done);
               if(status.Equals("Canceled"))
                  task.setStatus(TaskStatusEnum.Canceled);
               task.setProjectID(contents[4]);
               task.setDescription(contents[5]);
               list.Add(task);
            }
            reader.Close();
         }
         return list;
      }

      public void writeTasksToFiles(List<CodingProjectsTask> list) {
         foreach (CodingProjectsTask task in list) {
            var filePath = codingProjectUrl + "\\Tasks\\" + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public void writeCodingTaskToFile(CodingProjectsTask task) {
         var filePath = codingProjectUrl + "\\Tasks\\" + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      public List<CodingProjectsTask> readFinishedTasksFromFile(){
         var list = new List<CodingProjectsTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToHistory(List<CodingProjectsTask> list) {
         // to be implemented
      }

      public List<CodingProjectsGoal> readGoalsFromFiles(){
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

      public void checkCodingProjectsSaveFile() {
         if (!File.Exists(codingProjectsUrl + "\\meta.txt"))
            makeCodingProjectsSaveFile();
         readCodingProjectsSaveFile();
      }

      public void makeCodingProjectsSaveFile() {
         var filePath = codingProjectsUrl + "\\meta.txt";
         File.WriteAllText(filePath, "0\n0\n0\n");
      }

      public void writeCodingProjectsSaveFile() {
         var filePath = codingProjectsUrl + "\\meta.txt";
         string str = manager.getNextProjectID() + "\n";
         str += manager.getNextTaskID() + "\n";
         str += manager.getNextGoalID() + "\n";
         File.WriteAllText(filePath, str);
      }

      public void readCodingProjectsSaveFile() {
         var reader = new StreamReader(codingProjectsUrl + "\\meta.txt");
         manager.setNextProjectID(Convert.ToInt32(reader.ReadLine()));
         manager.setNextTaskID(Convert.ToInt32(reader.ReadLine()));
         manager.setNextGoalID(Convert.ToInt32(reader.ReadLine()));
      }

      // setter methods
      public void setCodingProjectsUrl(string param) { codingProjectsUrl = param; }
   }
}
