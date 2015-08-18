using System.Text;
using HackerCentral.Common.Enum;

namespace HackerCentral.Art {
   public class ArtIterationTask : ArtTask {
      private int startIteration;
      private int endIteration;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("ArtIterationTask" + "^");
         sb.Append(getPieceID().ToString() + "^");
         sb.Append(startIteration.ToString() + "^");
         sb.Append(endIteration.ToString() + "^");
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
      public int getStartIteration() { return startIteration; }
      public int getEndIteration() { return endIteration; }

      // setter methods
      public void setStartIteration(int param) { startIteration = param; }
      public void setEndIteration(int param) { endIteration = param; }
   }
}
