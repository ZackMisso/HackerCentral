using System;
using System.Text;

namespace HackerCentral.School {
   public class SchoolAssignment {
      private SchoolGradeContainer container;
      private DateTime dueDate;
      private string name;
      private float outOf;
      private float grade;
      private int assignmentID;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public SchoolGradeContainer getContainer() { return container; }
      public DateTime getDueDate() { return dueDate; }
      public string getName() { return name; }
      public float getOutOf() { return outOf; }
      public float getGrade() { return grade; }
      public int getAssignmentID() { return assignmentID; }

      // setter methods
      public void setContainer(SchoolGradeContainer param) { container = param; }
      public void setDueDate(DateTime param) { dueDate = param; }
      public void setName(string param) { name = param; }
      public void setOutOf(float param) { outOf = param; }
      public void setGrade(float param) { grade = param; }
      public void setAssignmentID(int param) { assignmentID = param; }
   }
}
