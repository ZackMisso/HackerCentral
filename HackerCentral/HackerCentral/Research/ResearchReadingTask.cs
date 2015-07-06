namespace HackerCentral.Research {
   public class ResearchReadingTask : ResearchTask{
      private ResearchReading reading;
      private int pagesToRead;
      private int pagesRead;
      private bool takeNotes;
      private bool readAll;

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public ResearchReading getReading() { return reading; }
      public int getPagesToRead() { return pagesToRead; }
      public int getPagesRead() { return pagesRead; }
      public bool getTakeNotes() { return takeNotes; }
      public bool getReadAll() { return readAll; }

      // setter methods
      public void setReading(ResearchReading param) { reading = param; }
      public void setPagesToRead(int param) { pagesToRead = param; }
      public void setPagesRead(int param) { pagesRead = param; }
      public void setTakeNotes(bool param) { takeNotes = param; }
      public void setReadAll(bool param) { readAll = param; }
   }
}
