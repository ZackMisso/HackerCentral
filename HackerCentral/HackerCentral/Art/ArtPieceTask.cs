using System.Text;

namespace HackerCentral.Art {
   public class ArtPieceTask : ArtTask{
      private ArtPiece piece;
      private int pieceID;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("ArtPieceTask" + "^");
         sb.Append(pieceID.ToString() + "^");
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
      public ArtPiece getPiece() { return piece; }
      public int getPieceID() { return pieceID; }

      // setter methods
      public void setPiece(ArtPiece param) { piece = param; }
      public void setPieceID(int param) { pieceID = param; }
   }
}
