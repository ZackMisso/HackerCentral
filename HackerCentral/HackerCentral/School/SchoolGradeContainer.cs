using System.Collections.Generic;

namespace HackerCentral.School {
   public class SchoolGradeContainer {
      private SchoolClass clas;
      private List<SchoolAssignment> gradedAssignments;
      private List<int> assignmentIDs;
      private string title;
      private float percentOfFinalGrade;
      private int containerID;
      private int clasID;

      public SchoolGradeContainer() {
         gradedAssignments = new List<SchoolAssignment>();
         assignmentIDs = new List<int>()
      }

      // getter methods
      public SchoolClass getClas() { return clas; }
      public List<SchoolAssignment> getGradedAssignments() { return gradedAssignments; }
      public List<int> getAssignmentIDs() { return assignmentIDs; }
      public string getTitle() { return title; }
      public float getPercentOfFinalGrade() { return percentOfFinalGrade; }
      public int getContainerID() { return containerID; }
      public int getClasID() { return clasID; }

      // setter methods
      public void setClas(SchoolClass param) { clas = param; }
      public void setGradedAssignments(List<SchoolAssignment> param) { gradedAssignments = param; }
      public void setAssignmentIDs(List<int> param) { assignmentIDs = param; }
      public void setTitle(string param) { title = param; }
      public void setPercentOfFinalGrade(float param) { percentOfFinalGrade = param; }
      public void setClasID(int param) { clasID = param; }
      public void setContainerID(int param) { containerID = param; }
   }
}
