namespace HackerCentral.Research {
   public class ResearchReading {
      private string path;
      private string notesPath;
      private int pagesRead;
      private int totalPages;
      private bool isFile;
      private bool isUrl;
      private bool done;

      // getter methods
      public string getPath() { return path; }
      public string getNotesPath() { return notesPath; }
      public int getPagesRead() { return pagesRead; }
      public int getTotalPages() { return totalPages; }
      public bool getIsFile() { return isFile; }
      public bool getIsUrl() { return isUrl; }
      public bool getDone() { return done; }

      // setter methods
      public void setPath(string param) { path = param; }
      public void setNotesPath(string param) { notesPath = param; }
      public void setPagesRead(int param) { pagesRead = param; }
      public void setTotalPages(int param) { totalPages = param; }
      public void setIsFile(bool param) { isFile = param; }
      public void setIsUrl(bool param) { isUrl = param; }
      public void setDone(bool param) { done = param; }
   }
}
