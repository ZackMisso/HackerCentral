using System;
using System.Text;

namespace HackerCentral.Art {
   public class ArtPiece {
      private DateTime began;
      private DateTime finished;
      private string file;
      private string name;
      private string format; // what ???
      private int iteration;
      private int pieceID;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public DateTime getBegan() { return began; }
      public DateTime getFinished() { return finished; }
      public string getFile() { return file; }
      public string getName() { return name; }
      public string getFormat() { return format; }
      public int getIteration() { return iteration; }
      public int getPieceID() { return pieceID; }

      // setter methods
      public void setBegan(DateTime param) { began = param; }
      public void setFinished(DateTime param) { finished = param; }
      public void setFile(string param) { file = param; }
      public void setName(string param) { name = param; }
      public void setFormat(string param) { format = param; }
      public void setIteration(int param) { iteration = param; }
      public void setPieceID(int param) { pieceID = param; }
   }
}
