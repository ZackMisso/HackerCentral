using System.Text;

namespace HackerCentral.Music {
   public class MusicPiece {
      private string name;
      private string location;
      private int iteration;
      private int pieceID;
      private bool done;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(name + "^");
         sb.Append(location + "^");
         sb.Append(iteration.ToString() + "^");
         sb.Append(pieceID.ToString() + "^");
         sb.Append(done + "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public string getName() { return name; }
      public string getLocation() { return location; }
      public int getIteration() { return iteration; }
      public int getPieceID() { return pieceID; }
      public bool getDone() { return done; }

      // setter methods
      public void setName(string param) { name = param; }
      public void setLocation(string param) { location = param; }
      public void setIteration(int param) { iteration = param; }
      public void setPieceID(int param) { pieceID = param; }
      public void setDone(bool param) { done = param; }
   }
}
