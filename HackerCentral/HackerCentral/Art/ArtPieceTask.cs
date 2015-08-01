using System.Text;

namespace HackerCentral.Art {
   public class ArtPieceTask : ArtTask{
      private ArtPiece piece;
      private int pieceID;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
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
