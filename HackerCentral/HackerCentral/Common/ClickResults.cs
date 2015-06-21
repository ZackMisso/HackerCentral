using HackerCentral.Common.Enum;

namespace HackerCentral.Common {
   public class ClickResults {
      //private ResultToHandleEnum resultToHandle;
      private bool shouldClose;
      private bool requestManager;
      private bool requestIO;

      public ClickResults() {
         //resultToHandle = ResultToHandleEnum.None;
         shouldClose = false;
         requestManager = false;
         requestIO = false;
      }

      // getter methods
      //public ResultToHandleEnum getResultToHandle() { return resultToHandle; }
      public bool getShouldClose() { return shouldClose; }
      public bool getRequestManager() { return requestManager; }
      public bool getRequestIO() { return requestIO; }

      // setter methods
      //public void setResultToHandle(ResultToHandleEnum param) { resultToHandle = param; }
      public void setShouldClose(bool param) { shouldClose = param; }
      public void setRequestManager(bool param) { requestManager = param; }
      public void setRequestIO(bool param) { requestIO = param; }
   }
}
