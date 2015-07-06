using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolIO : IO{
      private string schoolUrl;

      public SchoolIO(string url) {
         schoolUrl = url;
      }

      public List<SchoolClass> readClassesFromFiles() {
         var list = new List<SchoolClass>();
         // to be implemented
         return list;
      }

      public void writeClassesToFiles(List<SchoolClass> list) {
         // to be implemented
      }

      public List<SchoolClass> readClassesFromHistory() {
         var list = new List<SchoolClass>();
         // to be implemented
         return list;
      }

      public void writeClassesToHistory(List<SchoolClass> list) {
         // to be implemented
      }

      public List<SchoolAssignment> readAssignmentsFromFiles() {
         var list = new List<SchoolAssignment>();
         // to be implemented
         return list;
      }

      public void writeAssignmentsToFiles(List<SchoolAssignment> list) {
         // to be implemented
      }

      public List<SchoolAssignment> readAssignmentsFromHistory() {
         var list = new List<SchoolAssignment>();
         // to be implemented
         return list;
      }

      public void writeAssignmentsToHistory(List<SchoolAssignment> list) {
         // to be implemented
      }

      public List<SchoolGoal> readGoalsFromFiles() {
         var list = new List<SchoolGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToFiles(List<SchoolGoal> list) {
         // to be implemented
      }

      public List<SchoolGoal> readGoalsFromHistory() {
         var list = new List<SchoolGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<SchoolGoal> list) {
         // to be implemented
      }

      public List<SchoolTask> readTasksFromFiles() {
         var list = new List<SchoolTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<SchoolTask> list) {
         // to be implemented
      }

      public List<SchoolTask> readTasksFromHistory() {
         var list = new List<SchoolTask>();
         // to be implemetned
         return list;
      }

      public void writeTasksToHistory(List<SchoolTask> list) {
         // to be implemented
      }

      public void createDirectoryStructure() {
         if (!Directory.Exists(schoolUrl + "\\Assignments"))
            Directory.CreateDirectory(schoolUrl + "\\Assignments");
         if (!Directory.Exists(schoolUrl + "\\Goals"))
            Directory.CreateDirectory(schoolUrl + "\\Goals");
         if (!Directory.Exists(schoolUrl + "\\Tasks"))
            Directory.CreateDirectory(schoolUrl + "\\Tasks");
         if (!Directory.Exists(schoolUrl + "\\Classes"))
            Directory.CreateDirectory(schoolUrl + "\\Classes");
         if (!Directory.Exists(schoolUrl + "\\History"))
            Directory.CreateDirectory(schoolUrl + "\\History");
         if (!Directory.Exists(schoolUrl + "\\History\\Assignments"))
            Directory.CreateDirectory(schoolUrl + "\\History\\Assignments");
         if (!Directory.Exists(schoolUrl + "\\History\\Goals"))
            Directory.CreateDirectory(schoolUrl + "\\History\\Goals");
         if (!Directory.Exists(schoolUrl + "\\History\\Tasks"))
            Directory.CreateDirectory(schoolUrl + "\\History\\Tasks");
         if (!Directory.Exists(schoolUrl + "\\History\\Classes"))
            Directory.CreateDirectory(schoolUrl + "\\History\\Classes");
      }

      // setters
      public void setSchoolUrl(string param) { schoolUrl = param; }
   }
}
