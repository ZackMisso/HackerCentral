using System.Collections.Generic;

namespace HackerCentral.School {
   public class SchoolGradeContainer {
      private List<SchoolAssignment> gradedAssignments;
      private string title;
      private float percentOfFinalGrade;

      public SchoolGradeContainer() {
         gradedAssignments = new List<SchoolAssignment>();
      }

      // getter methods
      public List<SchoolAssignment> getGradedAssignments() { return gradedAssignments; }
      public string getTitle() { return title; }
      public float getPercentOfFinalGrade() { return percentOfFinalGrade; }

      // setter methods
      public void setGradedAssignments(List<SchoolAssignment> param) { gradedAssignments = param; }
      public void setTitle(string param) { title = param; }
      public void setPercentOfFinalGrade(float param) { percentOfFinalGrade = param; }
   }
}
