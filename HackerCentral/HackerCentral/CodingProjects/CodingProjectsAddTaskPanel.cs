using System;
using System.Drawing;
using System.Windows.Forms;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsAddTaskPanel : CustomPanel{
      private Label nameLabel;
      private Label descriptionLabel;
      private Label effortLabel;
      private Label codingProjectLabel;
      private TextBox nameBox;
      private TextBox descriptionBox;
      private TextBox effortLevelBox;
      private ListBox codingProjectsBox;
      private Button submitButton;

      public void initialize(Form1 form) {
         base.initialize(form);
         // create the name box
         nameBox = createTextBox(new Point(200,60), new Size(100,20));
         // create the description box
         descriptionBox = createTextBox(new Point(200, 140), new Size(200, 60));
         // create the effort level box
         effortLevelBox = createTextBox(new Point(200, 100), new Size(75,23));
         // create the submit button
         submitButton = createButton(new Point(100,200), new Size(75,23), "Submit");
         submitButton.Click += new System.EventHandler(submitButtonClicked);
         // create the name label
         nameLabel = createLabel(new Point(15, 60), new Size(70, 13), "Enter Project Name: ");
         // create the description label
         descriptionLabel = createLabel(new Point(15, 140), new Size(70, 13), "Enter Project Description: ");
         // create the effort level label
         effortLabel = createLabel(new Point(15, 100), new Size(70, 13), "Effort Level: ");
         // create the coding projects label
         codingProjectLabel = createLabel(new Point(420, 60), new Size(70, 13), "Choose Specific Project: ");
         // create the coding Projects Box
         codingProjectsBox = createListBox(new Point(600, 60), new Size(100, 20));
         var codingProjects = ((CodingProjectsManager)getManager()).getProjects();
         foreach(CodingProject project in codingProjects)
            codingProjectsBox.Items.Add(project.getName());
      }

      private void submitButtonClicked(object sender, EventArgs e) {
         // will add a Task if the UI Items are filled in
         if (!String.IsNullOrWhiteSpace(nameBox.Text) && !String.IsNullOrWhiteSpace(descriptionBox.Text) && !String.IsNullOrWhiteSpace(effortLevelBox.Text) && codingProjectsBox.SelectedItem != null) {
            var task = new CodingProjectsTask();
            //task.setTaskID(GlobalManager.getNextTaskID()); // maybe
            task.setName(nameBox.Text);
            task.setDescription(descriptionBox.Text);
            task.setEffort(Convert.ToInt32(effortLevelBox.Text));
            var manager = (CodingProjectsManager)getManager();
            CodingProject project = null;
            foreach(CodingProject proj in manager.getProjects())
               if(proj.getName().Equals((string)codingProjectsBox.SelectedItem, StringComparison.Ordinal))
                  project = proj;
            if(project != null){
               task.setProject(project);
               project.addTask(task);
            }
            manager.addNewCodingTask(task);
         }else{
            MessageBox.Show("Invalid input information");
         }
      }

      public override void clear() {
         removeControlFromWindow(nameBox);
         removeControlFromWindow(descriptionBox);
         removeControlFromWindow(effortLevelBox);
         removeControlFromWindow(submitButton);
         removeControlFromWindow(nameLabel);
         removeControlFromWindow(descriptionLabel);
         removeControlFromWindow(effortLabel);
         removeControlFromWindow(codingProjectLabel);
         removeControlFromWindow(codingProjectsBox);
         codingProjectsBox.Items.Clear();
      }
   }
}
