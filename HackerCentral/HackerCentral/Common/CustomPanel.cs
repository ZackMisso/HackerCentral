using System.Windows.Forms;

namespace HackerCentral.Common {
   public abstract class CustomPanel {
      private Form1 window;

      public CustomPanel() {
         // to be implemented
      }

      public void initialize(Form1 form) {
         window = form;
      }

      public void addControlToWindow(Control control) {
         window.Controls.Add(control);
      }

      public void removeControlFromWindow(Control control) {
         windows.Controls.Remove(control);
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

      public abstract ClickResults handleClick(int x, int y);
      public abstract void handleResults(ResultHandler handler);
      public abstract void clear();

      // getter methods
      public Form1 getWindow() { return window; }

      // setter methods
      public void setWindow(Form1 param) { window = param; }
   }
}
