using System.Text;

namespace HackerCentral.Art {
   public class ArtPieceTask : ArtTask{
      private ArtPiece piece;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public ArtPiece getPiece() { return piece; }

      // setter methods
      public void setPiece(ArtPiece param) { piece = param; }
   }
}
