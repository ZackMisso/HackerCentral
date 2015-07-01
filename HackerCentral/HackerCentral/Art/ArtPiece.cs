using System;

namespace HackerCentral.Art {
   public class ArtPiece {
      private DateTime began;
      private DateTime finished;
      private string file;
      private string name;
      private string format;
      private int iteration;

      // getter methods
      public DateTime getBegan() { return began; }
      public DateTime getFinished() { return finished; }
      public string getFile() { return file; }
      public string getName() { return name; }
      public string getFormat() { return format; }
      public int getIteration() { return iteration; }

      // setter methods
      public void setBegan(DateTime param) { began = param; }
      public void setFinished(DateTime param) { finished = param; }
      public void setFile(string param) { file = param; }
      public void setName(string param) { name = param; }
      public void setFormat(string param) { format = param; }
      public void setIteration(int param) { iteration = param; }
   }
}
