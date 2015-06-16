using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsIO : IO{
      private string globalCodingProjectsUrl;

      public CodingProjectsIO() {
         globalCodingProjectsUrl = "";
      }

      public List<CodingProject> readCodingProjectsFromFile(){
         var list = new List<CodingProject>();
         // to be implemented
         return list;
      }

      public List<CodingProjectsTask> readTasksFromFile(){
         var list = new List<CodingProjectsTask>();
         // to be impelemnted
         return list;
      }

      public List<CodingProjectsTask> readFinishedTasksFromFile(){
         var list = new List<CodingProjectsTask>();
         // to be implemented
         return list;
      }

      public List<CodingProjectsGoal> readGoalsFromFile(){
         var list = new List<CodingProjectsGoal>();
         // to be implemented
         return list;
      }

      public List<CodingProjectsGoal> readFinishedGoalsFromFile(){
         var list = new List<CodingProjectsGoal>();
         // to be implemented
         return list;
      }

      public int getLinesOfCodeForProject(string url, List<string> typesOfFiles){
         var lines = 0;
         // to be implemented
         return lines;
      }

      public void writeCodingProjectsDataToFile(List<CodingProject> projects){
         // to be implemented
      }

      public void writeCodingProjectsTasksToFile(List<CodingProjectsTask> tasks){
         // to be implemented
      }

      public void writeCodingProjectsGoalsToFile(List<CodingProjectsGoal> goals){
         // to be implemented
      }

      // setter methods
      public void setGlobalCodingProjectsUrl(string param) { globalCodingProjectsUrl = param; }
   }
}
