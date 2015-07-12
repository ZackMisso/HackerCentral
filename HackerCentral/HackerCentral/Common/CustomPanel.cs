using System.Drawing;
using System.Windows.Forms;

namespace HackerCentral.Common {
   public abstract class CustomPanel {
      private Form1 window;
      private Manager manager;
      private IO io;

      public void initialize(Form1 form) {
         window = form;
         manager = window.getCurrentManager();
         io = window.getCurrentIO();
      }

      public TextBox createTextBox(Point loc, Size size) {
         var box = new TextBox();
         box.Location = loc;
         box.Size = size;
         addControlToWindow(box);
         return box;
      }

      public Button createButton(Point loc, Size size, string text) {
         var button = new Button();
         button.Location = loc;
         button.Size = size;
         button.Text = text;
         button.UseVisualStyleBackColor = true;
         addControlToWindow(button);
         return button;
      }

      public Label createLabel(Point loc, Size size, string text) {
         var label = new Label();
         label.AutoSize = true;
         label.Location = loc;
         label.Size = size;
         label.ForeColor = Color.RoyalBlue;
         label.Text = text;
         addControlToWindow(label);
         return label;
      }

      public ListBox createListBox(Point loc, Size size) {
         var box = new ListBox();
         box.FormattingEnabled = true;
         box.Location = loc;
         box.Size = size;
         addControlToWindow(box);
         return box;
      }

      public void addControlToWindow(Control control) {
         window.Controls.Add(control);
      }

      public void removeControlFromWindow(Control control) {
         window.Controls.Remove(control);
      }

      public bool wasControlClicked(Control control, int x,int y) {
         // to be implemented
         return false;
      }

      public abstract void clear();

      // getter methods
      public Form1 getWindow() { return window; }
      public Manager getManager() { return manager; }
      public IO getIO() { return io; }

      // setter methods
      public void setWindow(Form1 param) { window = param; }
      public void setManager(Manager param) { manager = param; }
      public void setIO(IO param) { io = param; }
   }
}
