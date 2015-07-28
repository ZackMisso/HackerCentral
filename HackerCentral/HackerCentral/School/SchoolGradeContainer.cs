using System.Collections.Generic;

namespace HackerCentral.School {
   public class SchoolGradeContainer {
      private SchoolClass clas;
      private List<SchoolAssignment> gradedAssignments;
      private string title;
      private float percentOfFinalGrade;
      private int clasID;

      public SchoolGradeContainer() {
         gradedAssignments = new List<SchoolAssignment>();
      }

      // getter methods
      public SchoolClass getClas() { return clas; }
      public List<SchoolAssignment> getGradedAssignments() { return gradedAssignments; }
      public string getTitle() { return title; }
      public float getPercentOfFinalGrade() { return percentOfFinalGrade; }
      public int getClasID() { return clasID; }

      // setter methods
      public void setClas(SchoolClass param) { clas = param; }
      public void setGradedAssignments(List<SchoolAssignment> param) { gradedAssignments = param; }
      public void setTitle(string param) { title = param; }
      public void setPercentOfFinalGrade(float param) { percentOfFinalGrade = param; }
      public void setClasID(int param) { clasID = param; }
   }
}
