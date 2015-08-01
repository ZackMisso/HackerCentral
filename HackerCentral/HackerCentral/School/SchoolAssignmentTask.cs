namespace HackerCentral.School {
   public class SchoolAssignmentTask : SchoolTask{
      private SchoolAssignment assignment;
      private SchoolClass clas;
      private int assignmentID;
      private int clasID;
      private bool anyAssignmentForClass;

      // getter methods
      public SchoolAssignment getAssignment() { return assignment; }
      public SchoolClass getClass() { return clas; }
      public int getAssignmentID() { return assignmentID; }
      public int getClasID() { return clasID; }
      public bool getAnyAssignmentForClass() { return anyAssignmentForClass; }

      // setter methods
      public void setAssignment(SchoolAssignment param) { assignment = param; }
      public void setClass(SchoolClass param) { clas = param; }
      public void setAssignmentID(int param) { assignmentID = param; }
      public void setClassID(int param) { clasID = param; }
      public void setAnyAssingmentForClass(bool param) { anyAssignmentForClass = param; }
   }
}
