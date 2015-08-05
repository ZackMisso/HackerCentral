using System.Text;
using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicTask : Task{
      private MusicPiece piece;
      private int pieceID;
      private int startIteration;
      private int endIteration;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("MusicTask" + "^");
         sb.Append(pieceID.ToString() + "^");
         sb.Append(startIteration.ToString + "^");
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
      public MusicPiece getPiece() { return piece; }
      public int getPieceID() { return pieceID; }
      public int getStartIteration() { return startIteration; }
      public int getEndIteration() { return endIteration; }

      // setter methods
      public void setPiece(MusicPiece param) { piece = param; }
      public void setPieceID(int param) { pieceID = param; }
      public void setStartIteration(int param) { startIteration = param; }
      public void setEndIteration(int param) { endIteration = param; }
   }
}
