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

      public void writeClassToFile(SchoolClass clas) {
         // to be implemented
      }

      public void writeClassToHistory(SchoolClass clas) {
         // to be implemented
      }

      #endregion

      #region Assignments

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

      public void writeAssignmentToFile(SchoolAssignment assignment) {
         // to be implemented
      }

      public void writeAssignmentToHistory(SchoolAssignment assignment) {
         // to be implemented
      }

      #endregion

      #region Goals

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

      public void writeGoalToFile(SchoolGoal goal) {
         // to be implemented
      }

      public void writeGoalToHistory(SchoolGoal goal) {
         // to be implemented
      }

      #endregion

      #region Tasks

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

      public void writeTaskToFile(SchoolTask task) {
         // to be implemented
      }

      public void writeTaskToHistory(SchoolTask task) {
         // to be implemented
      }

      #endregion

      #region Grades

      public List<SchoolGradeContainer> readGradesFromFiles() {
         var list = new List<SchoolGradeContainer>();
         // to be implemented
         return list;
      }

      public void writeGradesToFiles(List<SchoolGradeContainer> list) {
         // to be implemented
      }

      public List<SchoolGradeContainer> readGradesFromHistory() {
         var list = new List<SchoolGradeContainer>();
         // to be implemetned
         return list;
      }

      public void writeGradesToHistory(List<SchoolGradeContainer> list) {
         // to be implemented
      }

      public void writeGradeToFile(SchoolGradeContainer grade) {
         // to be implemented
      }

      public void writeGradeToHistory(SchoolGradeContainer grade) {
         // to be implemented
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
