namespace HackerCentral.School {
   public class SchoolAssignmentTask : SchoolTask{
      private SchoolAssignment assignment;
      private SchoolClass clas;
      private int assignmentID;
      private int clasID;
      private bool anyAssignmentForClass;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("SchoolAssignmentTask" + "^");
         sb.Append(clasID.ToString() + "^");
         sb.Append(assignmentID.ToString() + "^");
         sb.Append(anyAssignmentForClass + "^");
         sb.Append(getName() + "^");
         sb.Append(getTaskID().ToString() + "^");
         sb.Append(getEffort().ToString() + "^");
         if (getStatus() == TaskStatusEnum.ToDo)
            sb.Append("To Do" + "^");
         if (getStatus() == TaskStatusEnum.InProgress)
            sb.Append("In Progress" + "^");
         if (getStatus() == TaskStatusEnum.Done)
            sb.Append("Done" + "^");
         if (getStatus() == TaskStatusEnum.Canceled)
            sb.Append("Canceled" + "^");
         if (getStatus() == TaskStatusEnum.Failed)
            sb.Append("Failed" + "^");
         sb.Append(getDescription() "^");
         sb.Append("\n");
         return sb.ToString();
      }

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
