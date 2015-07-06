using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Research {
   public class ResearchIO : IO{
      private string researchUrl;

      public ResearchIO(string url) {
         researchUrl = url;
      }

      public List<ResearchGoal> readGoalsFromFiles() {
         var list = new List<ResearchGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToFiles(List<ResearchGoal> list) {
         // to be implemented
      }

      public List<ResearchGoal> readGoalsFromHistory() {
         var list = new List<ResearchGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<ResearchGoal> list) {
         // to be implemented
      }

      public List<ResearchReading> readReadingsFromFiles() {
         var list = new List<ResearchReading>();
         // to be implemented
         return list;
      }

      public void writeReadingsToFiles(List<ResearchReading> list) {
         // to be implemented
      }

      public List<ResearchReading> readReadingsFromHistory() {
         var list = new List<ResearchReading>();
         // to be implemented
         return list;
      }

      public void writeReadingsToHistory(List<ResearchReading> list) {
         // to be implemented
      }

      public List<ResearchTask> readTasksFromFiles() {
         var list = new List<ResearchTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<ResearchTask> list) {
         // to be implemented
      }

      public List<ResearchTask> readTasksFromHistory() {
         var list = new List<ResearchTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToHistory(List<ResearchTask> list) {
         // to be implemented
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(researchUrl + "\\Tasks"))
            Directory.CreateDirectory(researchUrl + "\\Tasks");
         if (!Directory.Exists(researchUrl + "\\Goals"))
            Directory.CreateDirectory(researchUrl + "\\Goals");
         if (!Directory.Exists(researchUrl + "\\Readings"))
            Directory.CreateDirectory(researchUrl + "\\Readings");
         if (!Directory.Exists(researchUrl + "\\History"))
            Directory.CreateDirectory(researchUrl + "\\History");
         if (!Directory.Exists(researchUrl + "\\History\\Tasks"))
            Directory.CreateDirectory(researchUrl + "\\History\\Tasks");
         if (!Directory.Exists(researchUrl + "\\History\\Goals"))
            Directory.CreateDirectory(researchUrl + "\\History\\Goals");
         if (!Directory.Exists(researchUrl + "\\History\\Readings"))
            Directory.CreateDirectory(researchUrl + "\\History\\Readings");
      }

      // setters
      public void setResearchUrl(string param) { researchUrl = param; }
   }
}
