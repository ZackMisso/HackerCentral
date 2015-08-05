using System.Text;

namespace HackerCentral.Research {
   public class ResearchReadingTask : ResearchTask{
      private ResearchReading reading;
      private int readingID;
      private int pagesToRead;
      private int pagesRead;
      private bool takeNotes;
      private bool readAll;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("ResearchReadingTask" + "^");
         sb.Append(readingID.ToString() + "^");
         sb.Append(pagesToRead.ToString() + "^");
         sb.Append(pagesRead.ToString() + "^");
         sb.Append(takeNotes + "^");
         sb.Append(readAll + "^");
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
      public ResearchReading getReading() { return reading; }
      public int getReadingID() { return readingID; }
      public int getPagesToRead() { return pagesToRead; }
      public int getPagesRead() { return pagesRead; }
      public bool getTakeNotes() { return takeNotes; }
      public bool getReadAll() { return readAll; }

      // setter methods
      public void setReading(ResearchReading param) { reading = param; }
      public void setReadingID(int param) { readingID = param; }
      public void setPagesToRead(int param) { pagesToRead = param; }
      public void setPagesRead(int param) { pagesRead = param; }
      public void setTakeNotes(bool param) { takeNotes = param; }
      public void setReadAll(bool param) { readAll = param; }
   }
}
