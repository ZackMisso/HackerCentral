using System;
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
         var files = Directory.GetFiles(getClassUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var clas = new SchoolClass();
               clas.setName(contents[0]);
               clas.setClassID(Convert.ToInt32(contents[1]));
               var grades = Convert.ToInt32(contents[2]);
               var itr = 3;
               for(var i = 0; i < grades; i++)
                  clas.getGradeIDs().Add(Convert.ToInt32(contents[itr++]));
               var assingments = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < assingments; i++)
                  clas.getAssignmentIDs().Add(Convert.ToInt32(contents[itr++]));
               list.Add(clas);
            }
         }
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
         var files = Directory.GetFiles(getClassHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var clas = new SchoolClass();
               clas.setName(contents[0]);
               clas.setClassID(Convert.ToInt32(contents[1]));
               var grades = Convert.ToInt32(contents[2]);
               var itr = 3;
               for (var i = 0; i < grades; i++)
                  clas.getGradeIDs().Add(Convert.ToInt32(contents[itr++]));
               var assingments = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < assingments; i++)
                  clas.getAssignmentIDs().Add(Convert.ToInt32(contents[itr++]));
               list.Add(clas);
            }
         }
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
         var files = Directory.GetFiles(getAssignmentUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var assignment = new SchoolAssignment();
               assignment.setAssignmentID(Convert.ToInt32(contents[0]));
               assignment.setContainerID(Convert.ToInt32(contents[1]));
               var dueDate = contents[3];
               // set the due date
               assignment.setName(contents[4]);
               assignment.setOutOf((float)Convert.ToDouble(contents[5]));
               assignment.setGrade((float)Convert.ToDouble(contents[6]));
               list.Add(assignment);
            }
         }
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
         var files = Directory.GetFiles(getAssignmentHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var assignment = new SchoolAssignment();
               assignment.setAssignmentID(Convert.ToInt32(contents[0]));
               assignment.setContainerID(Convert.ToInt32(contents[1]));
               var dueDate = contents[3];
               // set the due date
               assignment.setName(contents[4]);
               assignment.setOutOf((float)Convert.ToDouble(contents[5]));
               assignment.setGrade((float)Convert.ToDouble(contents[6]));
               list.Add(assignment);
            }
         }
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
         var files = Directory.GetFiles(getGoalUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var goal = new SchoolGoal();
               goal.setGoalID(Convert.ToInt32(contents[1]));
               var status = contents[2];
               if (status.Equals("None"))
                  goal.setStatus(GoalStatusEnum.None);
               else if (status.Equals("NotStarted"))
                  goal.setStatus(GoalStatusEnum.NotStarted);
               else if (status.Equals("InProgress"))
                  goal.setStatus(GoalStatusEnum.InProgress);
               else if (status.Equals("Succeeded"))
                  goal.setStatus(GoalStatusEnum.Succeeded);
               else
                  goal.setStatus(GoalStatusEnum.Failed);
               goal.setName(contents[3]);
               goal.setPercentAccomplished((float)Convert.ToDouble(contents[4]));
               var classIds = Convert.ToInt32(contents[5]);
               var itr = 6;
               for (var i = 0; i < classIds; i++)
                  goal.getClassIDs().Add(Convert.ToInt32(contents[itr++]));
               var containers = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < containers; i++)
                  goal.getContainerIDs().Add(Convert.ToInt32(contents[itr++]));
               var averages = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < avergaes; i++)
                  goal.getGoalAverages().Add((float)Convert.ToDouble(contents[itr++]));
               goal.setByClass(contents[itr++].Equals("true"));
               list.Add(goal);
            }
         }
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
         var files = Directory.GetFiles(getGoalHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var goal = new SchoolGoal();
               goal.setGoalID(Convert.ToInt32(contents[1]));
               var status = contents[2];
               if (status.Equals("None"))
                  goal.setStatus(GoalStatusEnum.None);
               else if (status.Equals("NotStarted"))
                  goal.setStatus(GoalStatusEnum.NotStarted);
               else if (status.Equals("InProgress"))
                  goal.setStatus(GoalStatusEnum.InProgress);
               else if (status.Equals("Succeeded"))
                  goal.setStatus(GoalStatusEnum.Succeeded);
               else
                  goal.setStatus(GoalStatusEnum.Failed);
               goal.setName(contents[3]);
               goal.setPercentAccomplished((float)Convert.ToDouble(contents[4]));
               var classIds = Convert.ToInt32(contents[5]);
               var itr = 6;
               for (var i = 0; i < classIds; i++)
                  goal.getClassIDs().Add(Convert.ToInt32(contents[itr++]));
               var containers = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < containers; i++)
                  goal.getContainerIDs().Add(Convert.ToInt32(contents[itr++]));
               var averages = Convert.ToInt32(contents[itr++]);
               for (var i = 0; i < avergaes; i++)
                  goal.getGoalAverages().Add((float)Convert.ToDouble(contents[itr++]));
               goal.setByClass(contents[itr++].Equals("true"));
               list.Add(goal);
            }
         }
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
         var files = Directory.GetFiles(getTaskUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               if (contents[0].Equals("SchoolStudyTask"))
                  list.Add(readSchoolStudyTask(contents));
               else if (contents[0].Equals("SchoolAssignmentTask"))
                  list.Add(readSchoolAssignmentTask(contents));
            }
         }
         return list;
      }

      private SchoolTask readSchoolStudyTask(string[] contents) {
         var task = new SchoolStudyTask();
         task.setClasID(Convert.ToInt32(contents[1]));
         task.setHours(Convert.ToInt32(contents[2]));
         task.setInDays(Convert.ToInt32(contents[3]));
         var startDate = contents[4];
         // set the start date
         task.setWeekly(contents[5].Equals("true"));
         task.setName(contents[6]);
         task.setTaskID(contents[7]);
         task.setEffort(Convert.ToInt32(contents[8]));
         var status = contents[9];
         if (status.Equals("ToDo"))
            task.setStatus(TaskStatusEnum.ToDo);
         else if (status.Equals("InProgress"))
            task.setStatus(TaskStatusEnum.InProgress);
         else if (status.Equals("Done"))
            task.setStatus(TaskStatusEnum.Done);
         else if (status.Equals("Canceled"))
            task.setStatus(TaskStatusEnum.Canceled);
         else
            task.setStatus(TaskStatusEnum.Failed);
         task.setDescription(contents[10]);
         return task;
      }

      private SchoolTask readAssignmentTask(string[] contents) {
         var task = new SchoolAssignmentTask();
         task.setClassID(Convert.ToInt32(contents[1]));
         task.setAssignmentID(Convert.ToInt32(contents[2]));
         task.setAnyAssignmentForClass(contents[3].Equals("true"));
         task.setName(contents[4]);
         task.setTaskID(contents[5]);
         task.setEffort(Convert.ToInt32(contents[6]));
         var status = contents[7];
         if (status.Equals("ToDo"))
            task.setStatus(TaskStatusEnum.ToDo);
         else if (status.Equals("InProgress"))
            task.setStatus(TaskStatusEnum.InProgress);
         else if (status.Equals("Done"))
            task.setStatus(TaskStatusEnum.Done);
         else if (status.Equals("Canceled"))
            task.setStatus(TaskStatusEnum.Canceled);
         else
            task.setStatus(TaskStatusEnum.Failed);
         task.setDescription(contents[8]);
         return task;
      }

      public void writeTasksToFiles(List<SchoolTask> list) {
         foreach (SchoolTask task in list) {
            var filePath = getTaskUrl() + task.getName() + ".txt";
            File.WriteAllText(filePath, task.ToString());
         }
      }

      public List<SchoolTask> readTasksFromHistory() {
         var list = new List<SchoolTask>();
         var files = Directory.GetFiles(getTaskHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               if (contents[0].Equals("SchoolStudyTask"))
                  list.Add(readSchoolStudyTask(contents));
               else if (contents[0].Equals("SchoolAssignmentTask"))
                  list.Add(readSchoolAssignmentTask(contents));
            }
         }
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
         var files = Directory.GetFiles(getGradeUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var grade = new SchoolGradeContainer();
               grade.setClasID(Convert.ToInt32(contents[0]));
               grade.setContainerID(Convert.ToInt32(contents[1]));
               grade.setTitle(contents[2]);
               grade.setPercentOfFinalGrade((float)Convert.ToDouble(contents[3]));
               var assignments = Convert.ToInt32(contents[4]);
               var itr = 5;
               for (var i = 0; i < assignments; i++)
                  grade.getAssignmentIDs().Add(Convert.ToInt32(contents[itr++]));
               list.Add(grade);
            }
         }
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
         var files = Directory.GetFiles(getGradeHistoryUrl());
         foreach (string file in files) {
            var reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null) {
               var contents = line.Split('^');
               var grade = new SchoolGradeContainer();
               grade.setClasID(Convert.ToInt32(contents[0]));
               grade.setContainerID(Convert.ToInt32(contents[1]));
               grade.setTitle(contents[2]);
               grade.setPercentOfFinalGrade((float)Convert.ToDouble(contents[3]));
               var assignments = Convert.ToInt32(contents[4]);
               var itr = 5;
               for (var i = 0; i < assignments; i++)
                  grade.getAssignmentIDs().Add(Convert.ToInt32(contents[itr++]));
               list.Add(grade);
            }
         }
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

      #region MetaData

      public void checkSchoolSaveFile() {
         // To be implemented
         //if (!File.Exists(codingProjectsUrl + "\\meta.txt"))
         //   makeCodingProjectsSaveFile();
         //readCodingProjectsSaveFile();
      }

      public void makeSchoolSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //File.WriteAllText(filePath, "0\n0\n0\n");
      }

      public void writeSchoolSaveFile() {
         // to be implemented
         //var filePath = codingProjectsUrl + "\\meta.txt";
         //string str = manager.getNextProjectID() + "\n";
         //str += manager.getNextTaskID() + "\n";
         //str += manager.getNextGoalID() + "\n";
         //File.WriteAllText(filePath, str);
      }

      public void readSchoolSaveFile() {
         // to be implemented
         //var reader = new StreamReader(codingProjectsUrl + "\\meta.txt");
         //manager.setNextProjectID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextTaskID(Convert.ToInt32(reader.ReadLine()));
         //manager.setNextGoalID(Convert.ToInt32(reader.ReadLine()));
      }

      #endregion

      // setters
      public void setSchoolUrl(string param) { schoolUrl = param; }
   }
}
