using System;
using System.Drawing;
using System.Windows.Forms;
using HackerCentral.Common;
using HackerCentral.Common.Enum;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsNewProjectPanel : CustomPanel{
      private TextBox nameBox;
      private TextBox descriptionBox;
      private TextBox extensionsBox;
      private Label path;
      private Label nameLabel;
      private Label descriptionLabel;
      private Label extensionsLabel;
      private Button submitButton;

      public void initialize(Form1 form){
         base.initialize(form);
         // create the name box
         nameBox = createTextBox(new Point(200, 60), new Size(100, 20));
         // create the description box
         descriptionBox = createTextBox(new Point(200, 100), new Size(200, 60));
         // create the extensions box
         extensionsBox = createTextBox(new Point(200, 140), new Size(200, 20));
         // create the submit button
         submitButton = createButton(new Point(100, 200), new Size(75, 23), "Submit");
         submitButton.Click += new System.EventHandler(submitButtonClicked);
         // create the url label
         path = createLabel(new Point(15, 40), new Size(70, 13), ""); 
         // create the name label
         nameLabel = createLabel(new Point(15, 60), new Size(70, 13), "Enter Project Name: ");
         // create the description label
         descriptionLabel = createLabel(new Point(15, 100), new Size(70, 13), "Enter Project Description: ");
         // create the extensions label
         extensionsLabel = createLabel(new Point(15, 140), new Size(70, 13), "Code Extensions");
      }

      private void submitButtonClicked(object sender, EventArgs e) {
         if (!String.IsNullOrWhiteSpace(nameBox.Text) && !String.IsNullOrWhiteSpace(descriptionBox.Text)) {
            var folderDialog = new FolderBrowserDialog();
            var result = folderDialog.ShowDialog();
            if (result == DialogResult.OK) {
               path.Text = folderDialog.SelectedPath;
               createCodingProject(folderDialog.SelectedPath);
               MessageBox.Show("Created Project " + nameBox.Text);
            }
         } else {
            MessageBox.Show("Invalid Input Information");
         }
      }

      private void createCodingProject(string url) {
         var project = new CodingProject(url);
         project.setName(nameBox.Text);
         project.setDescription(descriptionBox.Text);
         var extensions = extensionsBox.Text.Split(',');
         foreach (string extension in extensions)
            project.getTypesOfFiles().Add(extension);
         project.update((CodingProjectsIO)getIO());
         if (((CodingProjectsManager)getManager()).doesCodingProjectExistByName(project)) {
            MessageBox.Show("Project with the same name already exists");
            return;
         }
         ((CodingProjectsManager)getManager()).addNewCodingProject(project);
      }

      public override void clear() {
         removeControlFromWindow(nameBox);
         removeControlFromWindow(descriptionBox);
         removeControlFromWindow(extensionsBox);
         removeControlFromWindow(submitButton);
         removeControlFromWindow(path);
         removeControlFromWindow(nameLabel);
         removeControlFromWindow(descriptionLabel);
         removeControlFromWindow(extensionsLabel);
      }
   }
}
