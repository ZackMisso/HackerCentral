﻿using System;
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

      public CodingProjectsAddTaskPanel() : base(){
         nameLabel = null;
         descriptionName = null;
         effortName = null;
         codingProject = null;
         nameBox = null;
         descriptionBox = null;
         effortLevelBox = null;
         codingProjectsBox = null;
         submitButton = null;
      }

      // TODO :: Add in logic to create the list box

      public void initialize(Form1 form) {
         base.initialize(form);
         // create the name box
         nameBox = new TextBox();
         nameBox.Location = new System.Drawing.Point(200, 60);
         nameBox.Size = new System.Drawing.Size(100, 20);
         // create the description box
         descriptionBox = new TextBox();
         descriptionBox.Location = new System.Drawing.Point(200, 140);
         descriptionBox.Size = new System.Drawing.Size(200, 60);
         // create the effort level box
         effortLevelBox = new TextBox();
         effortLevelBox.Location = new System.Drawing.Point(200,100);
         effortLevelBox.Size = new System.Drawing.Size(40, 20);
         // create the submit button
         submitButton = new Button();
         submitButton.Location = new System.Drawing.Point(100, 200);
         submitButton.Size = new System.Drawing.Size(75, 23);
         submitButton.Text = "Submit";
         submitButton.UseVisualStyleBackColor = true;
         submitButton.Click += new System.EventHandler(submitButtonClicked);
         // create the name label
         nameLabel = new Label();
         nameLabel.AutoSize = true;
         nameLabel.Location = new Point(15, 60);
         nameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
         nameLabel.Size = new Size(70, 13);
         nameLabel.Text = "Enter Project Name: ";
         // create the description label
         descriptionLabel = new Label();
         descriptionLabel.AutoSize = true;
         descriptionLabel.Location = new Point(15, 140);
         descriptionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
         descriptionLabel.Size = new Size(70, 13);
         descriptionLabel.Text = "Enter Project Description: ";
         // create the effort level label
         effortLabel = new Label();
         effortLabel.AutoSize = true;
         effortLabel.Location = new Point(15, 100);
         effortLabel.ForeColor = System.Drawing.Color.RoyalBlue;
         effortLabel.Size = new Size(70, 13);
         effortLabel.Text = "Effort Level: ";
         // create the coding Projects Box
         codingProjectsBox.FormattingEnabled = true;
         codingProjectsBox.Location = new System.Drawing.Point(400, 180);
         codingProjectsBox.Size = new System.Drawing.Size(100, 30);
         var codingProjects = ((CodingProjectsManager)getManager()).getProjects();
         for(CodingProject project in codingProjects)
            codingProjectsBox.Add(project.getName());
         // add the items to the level
         addControlToWindow(nameBox);
         addControlToWindow(descriptionBox);
         addControlToWindow(effortLevelBox)
         addControlToWindow(submitButton);
         addControlToWindow(nameLabel);
         addControlToWindow(descriptionLabel);
         addControlToWindow(effortLabel);
         addControlToWindow(codingProjectsBox);
      }

      private void submitButtonClicked() {
         // will add a Task if the UI Items are filled in
         if (!String.IsNullOrWhiteSpace(nameBox.Text) && !String.IsNullOrWhiteSpace(descriptionBox.Text) && !String.IsNullOrWhiteSpace(effortLevelBox.Text) && codingProjectsBox.SelectedItem != null) {
            var task = new CodingProjectsTask();
            //task.setTaskID(GlobalManager.getNextTaskID()); // maybe
            task.setName(nameBox.Text);
            task.setDescription(descriptionBox.Text);
            task.setEffortLevel(Convert.ToInt32(effortLevelBox.Text));
            var manager = (CodingProjectsManager)getManager();
            var project = null;
            for(CodingProject proj in manager.getProjects())
               if(proj.getName().Equals((string)codingProjectsBox.SelectedItem, StringComparison.Ordinal))
                  project = proj;
            if(project != null){
               task.setProject(project);
               project.addTask(task);
            }
            manager.addNewCodingTask(task)
         }else{
            MessageBox.Show("Invalid input information");
         }
      }

      public override void clear() {
         removeControlFromWindow(nameBox);
         removeControlFromWindow(descriptionBox);
         removeControlFromWindow(effortLevelBox)
         removeControlFromWindow(submitButton);
         removeControlFromWindow(nameLabel);
         removeControlFromWindow(descriptionLabel);
         removeControlFromWindow(effortLabel);
         revomeControlFromWindow(codingProjectsBox);
         codingProjectsBox.Items.clear();
      }
   }
}
