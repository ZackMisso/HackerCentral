using System.Text;
using System.Collections.Generic;

namespace HackerCentral.School {
   public class SchoolClass {
      private List<SchoolGradeContainer> grades;
      private List<SchoolAssignment> assignments;
      private string name;

      public SchoolClass() {
         grades = new List<SchoolGradeContainer>();
         assignments = new List<SchoolAssignment>();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public List<SchoolGradeContainer> getGrades() { return grades; }
      public List<SchoolAssignment> getAssignments() { return assignments; }
      public string getName() { return name; }

      // setter methods
      public void setGrades(List<SchoolGradeContainer> param) { grades = param; }
      public void setAssignments(List<SchoolAssignment> param) { assignments = param; }
      public void setName(string param) { name = param; }
   }
}
