using System.Text;
using System.Collections.Generic;

namespace HackerCentral.School {
   public class SchoolClass {
      private List<SchoolGradeContainer> grades;
      private List<SchoolAssignment> assignments;
      private List<int> gradeIDs;
      private List<int> assignmentIDs;
      private string name;
      private int classID;

      public SchoolClass() {
         grades = new List<SchoolGradeContainer>();
         assignments = new List<SchoolAssignment>();
         gradeIDs = new List<int>();
         assignmentIDs = new List<int>();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(name + "^");
         sb.Append(classID.ToString() + "^");
         sb.Append(grades.Count + "^");
         foreach (SchoolGradeContainer grade in grades)
            sb.Append(grade.getGradeID() + "^");
         sb.Append(assignments.Count + "^");
         foreach (SchoolAssignment assignment in assignments)
            sb.Append(assignment.getAssignmentID() + "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public List<SchoolGradeContainer> getGrades() { return grades; }
      public List<SchoolAssignment> getAssignments() { return assignments; }
      public List<int> getGradeIDs() { return gradeIDs; }
      public List<int> getAssignmentIDs() { return assignmentIDs; }
      public string getName() { return name; }
      public int getClassID() { return classID; }

      // setter methods
      public void setGrades(List<SchoolGradeContainer> param) { grades = param; }
      public void setAssignments(List<SchoolAssignment> param) { assignments = param; }
      public void setGradeIDs(List<int> param) { gradeIDs = param; }
      public void setAssignmentIDs(List<int> param) { assignmentIDs = param; }
      public void setName(string param) { name = param; }
      public void setClassID(int param) { classID = param; }
   }
}
