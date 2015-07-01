using System.Windows.Forms;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsNewGoalPanel : CustomPanel{
      private CodingProject selectedProject;
      private List<Label> tasks;
      private ListBox typeOfGoalBox;
      private ListBox projectsBox;
      private ListBox tasksBox;
      private TextBox numberInput;
      private Label typeOfGoalLabel;
      private Label projectLabel;
      private Label addTask;
      private Button submitButton;
      private Button addTaskButton;

      public void initialize(Form1 form) {
         base.initialize(form);
         // to be implemented
      }

      public override void clear() {
         selectedProject = null;
         // to be implmented if more is needed
      }
   }
}
