using System.Text;

namespace HackerCentral.Art {
   public class ArtIterationTask : ArtTask {
      private ArtPiece piece;
      private int pieceID;
      private int startIteration;
      private int endIteration;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public ArtPiece getPiece() { return piece; }
      public int getPieceID() { return pieceID; }
      public int getStartIteration() { return startIteration; }
      public int getEndIteration() { return endIteration; }

      // setter methods
      public void setPiece(ArtPiece param) { piece = param; }
      public void setPieceID(int param) { pieceID = param; }
      public void setStartIteration(int param) { startIteration = param; }
      public void setEndIteration(int param) { endIteration = param; }
   }
}
