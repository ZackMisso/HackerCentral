using System.IO;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolIO : IO{
      private SchoolManager manager;
      private string schoolUrl;

      public SchoolIO(SchoolManager param,string url) {
         manager = param;
         schoolUrl = url;
      }

      #region Classes

      public List<SchoolClass> readClassesFromFiles() {
         var list = new List<SchoolClass>();
         // to be implemented
         return list;
      }

      public void writeClassesToFiles(List<SchoolClass> list) {
         foreach (SchoolClass clas in list) {
            var filePath = getClassUrl() + clas.getName() + ".txt";
            File.WriteAllText(filePath, clas.ToString());
         }
      }

      public List<SchoolClass> readClassesFromHistory() {
         var list = new List<SchoolClass>();
         // to be implemented
         return list;
      }

      public void writeClassesToHistory(List<SchoolClass> list) {
         foreach (SchoolClass clas in list) {
            var filePath = getClassHistoryUrl() + clas.getName() + ".txt";
            File.WriteAllText(filePath, clas.ToString());
         }
      }

      public void writeClassToFile(SchoolClass clas) {
         var filePath = getClassUrl() + clas.getName() + ".txt";
         File.WriteAllText(filePath, clas.ToString());
      }

      public void writeClassToHistory(SchoolClass clas) {
         var filePath = getClassHistoryUrl() + clas.getName() + ".txt";
         File.WriteAllText(filePath, clas.ToString());
      }

      #endregion

      #region Assignments

      public List<SchoolAssignment> readAssignmentsFromFiles() {
         var list = new List<SchoolAssignment>();
         // to be implemented
         return list;
      }

      public void writeAssignmentsToFiles(List<SchoolAssignment> list) {
         foreach (SchoolAssignment assignment in list) {
            var filePath = getAssignmentUrl() + assignment.getName() + ".txt";
            File.WriteAllText(filePath, assignment.ToString());
         }
      }

      public List<SchoolAssignment> readAssignmentsFromHistory() {
         var list = new List<SchoolAssignment>();
         // to be implemented
         return list;
      }

      public void writeAssignmentsToHistory(List<SchoolAssignment> list) {
         foreach (SchoolAssignment assignment in list) {
            var filePath = getAssignmentHistoryUrl() + assignment.getName() + ".txt";
            File.WriteAllText(filePath, assignment.ToString());
         }
      }

      public void writeAssignmentToFile(SchoolAssignment assignment) {
         var filePath = getAssignmentUrl() + assignment.getName() + ".txt";
         File.WriteAllText(filePath, assignment.ToString());
      }

      public void writeAssignmentToHistory(SchoolAssignment assignment) {
         var filePath = getAssignmentHistoryUrl() + assignment.getName() + ".txt";
         File.WriteAllText(filePath, assignment.ToString());
      }

      #endregion

      #region Goals

      public List<SchoolGoal> readGoalsFromFiles() {
         var list = new List<SchoolGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToFiles(List<SchoolGoal> list) {
         foreach (SchoolGoal goal in list) {
            var filePath = getGoalUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public List<SchoolGoal> readGoalsFromHistory() {
         var list = new List<SchoolGoal>();
         // to be implemented
         return list;
      }

      public void writeGoalsToHistory(List<SchoolGoal> list) {
         foreach (SchoolGoal goal in list) {
            var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
            File.WriteAllText(filePath, goal.ToString());
         }
      }

      public void writeGoalToFile(SchoolGoal goal) {
         var filePath = getGoalUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      public void writeGoalToHistory(SchoolGoal goal) {
         var filePath = getGoalHistoryUrl() + goal.getName() + ".txt";
         File.WriteAllText(filePath, goal.ToString());
      }

      #endregion

      #region Tasks

      public List<SchoolTask> readTasksFromFiles() {
         var list = new List<SchoolTask>();
         // to be implemented
         return list;
      }

      public void writeTasksToFiles(List<SchoolTask> list) {
         foreach (SchoolTask task in list) {
            var filePath = getTaskUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public List<SchoolTask> readTasksFromHistory() {
         var list = new List<SchoolTask>();
         // to be implemetned
         return list;
      }

      public void writeTasksToHistory(List<SchoolTask> list) {
         foreach (SchoolTask task in list) {
            var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public void writeTaskToFile(SchoolTask task) {
         var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      public void writeTaskToHistory(SchoolTask task) {
         var filePath = getTaskHistoryUrl() + task.getName() + ".txt";
         File.WriteAllText(filePath, task.ToString());
      }

      #endregion

      #region Grades

      public List<SchoolGradeContainer> readGradesFromFiles() {
         var list = new List<SchoolGradeContainer>();
         // to be implemented
         return list;
      }

      public void writeGradesToFiles(List<SchoolGradeContainer> list) {
         foreach (SchoolGradeContainer grade in list) {
            var filePath = getGradeUrl() + grade.getName() + ".txt";
            File.WriteAllText(filePath, grade.ToString());
         }
      }

      public List<SchoolGradeContainer> readGradesFromHistory() {
         var list = new List<SchoolGradeContainer>();
         // to be implemetned
         return list;
      }

      public void writeGradesToHistory(List<SchoolGradeContainer> list) {
         foreach (SchoolGradeContainer grade in list) {
            var filePath = getGradeHistoryUrl() + grade.getName() + ".txt";
            File.WriteAllText(filePath, grade.ToString());
         }
      }

      public void writeGradeToFile(SchoolGradeContainer grade) {
         var filePath = getGradeUrl() + grade.getName() + ".txt";
         File.WriteAllText(filePath, grade.ToString());
      }

      public void writeGradeToHistory(SchoolGradeContainer grade) {
         var filePath = getGradeHistoryUrl() + grade.getName() + ".txt";
         File.WriteAllText(filePath, grade.ToString());
      }

      #endregion

      public void createDirectoryStructure() {
         if (!Directory.Exists(getAssignmentUrl())
            Directory.CreateDirectory(getAssignmentUrl());
         if (!Directory.Exists(getGoalUrl()))
            Directory.CreateDirectory(getGoalUrl());
         if (!Directory.Exists(getTaskUrl()))
            Directory.CreateDirectory(getTaskUrl());
         if (!Directory.Exists(getClassUrl()))
            Directory.CreateDirectory(getClassUrl());
         if (!Directory.Exists(getGradeUrl())) // grade containers
            Directory.CreateDirectory(getGradeUrl());
         if (!Directory.Exists(getHistoryUrl()))
            Directory.CreateDirectory(getHistoryUrl());
         if (!Directory.Exists(getAssignmentHistoryUrl()))
            Directory.CreateDirectory(getAssignmentHistoryUrl());
         if (!Directory.Exists(getGoalHistoryUrl()))
            Directory.CreateDirectory(getGoalHistoryUrl());
         if (!Directory.Exists(getTaskHistoryUrl()))
            Directory.CreateDirectory(getTaskHistoryUrl());
         if (!Directory.Exists(getClassHistoryUrl()))
            Directory.CreateDirectory(getClassHistoryUrl());
         if (!Directory.Exists(getGradeHistoryUrl()))
            Directory.CreateDirectory(getGradeHistoryUrl());
      }

      private string getAssignmentUrl() { return schoolUrl + "\\Assignments"; }
      private string getGoalUrl() { return schoolUrl + "\\Goals"; }
      private string getTaskUrl() { return schoolUrl + "\\Tasks"; }
      private string getClassUrl() { return schoolUrl + "\\Classes"; }
      private string getGradeUrl() { return schoolUrl + "\\Grades"; }
      private string getHistoryUrl() { return schoolUrl + "\\History"; }
      private string getAssignmentHistoryUrl() { return getHistoryUrl() + "\\Assignments"; }
      private string getGoalHistoryUrl() { return getHistoryUrl() + "\\Goals"; }
      private string getTaskHistoryUrl() { return getHistoryUrl() + "\\Tasks"; }
      private string getClassHistoryUrl() { return getHistoryUrl() + "\\Classes"; }
      private string getGradeHistoryUrl() { return getHistoryUrl() + "\\Grades"; }


      // setters
      public void setSchoolUrl(string param) { schoolUrl = param; }
   }
}
