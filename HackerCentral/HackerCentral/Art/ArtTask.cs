using HackerCentral.Common;

namespace HackerCentral.Art {
   public class ArtTask : Task{
      private ArtPiece piece;
      private int pieceID;

      // getter methods
      public ArtPiece getPiece() { return piece; }
      public int getPieceID() { return pieceID; }

      // setter methods
      public void setPiece(ArtPiece param) { piece = param; }
      public void setPieceID(int param) { pieceID = param; }
   }
}
