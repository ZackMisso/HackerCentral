using System.Windows.Forms;

namespace HackerCentral.Common {
   public abstract class CustomPanel {
      private Form1 window;
      private Manager manager;
      private IO io;

      public CustomPanel() {
         window = null;
         manager = null;
         io = null;
      }

      public void initialize(Form1 form) {
         window = form;
      }

      public void addControlToWindow(Control control) {
         window.Controls.Add(control);
      }

      public void removeControlFromWindow(Control control) {
         window.Controls.Remove(control);
      }

      //public void addLabelToWindow(Label label) {
      //   window.Controls.Add(label);
      //}

      //public void removeLabelFromWindow(Label label) {
      //   window.Controls.Remove(label);
      //}

      public bool wasControlClicked(Control control, int x,int y) {
         // to be implemented
         return false;
      }

      //public abstract ClickResults handleClick(int x, int y);
      //public abstract void handleResults(ResultHandler handler);
      public abstract void clear();

      // getter methods
      public Form1 getWindow() { return window; }
      public Manager getManager() { return manager; }
      public IO getIO() { return io; }

      // setter methods
      public void setWindow(Form1 param) { window = param; }
      public void setManager(Manager param) { manager = param; }
      public void setIO(IO param) { io = paraml; }
   }
}
