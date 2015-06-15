using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsListOfProjectsPanel : CustomPanel{
      private CodingProjectsManager manager;
      private List<Label> projectDescriptionLabels;
      private List<Label> projectNameLabels;
      private List<Label> projectNumberOfLinesLabels;

      public CodingProjectsListOfProjectsPanel() : base() {
         projectDescriptionLabels = new List<Label>();
         projectNameLabels = new List<Label>();
         projectNumberOfLinesLabels = new List<Label>();
      }

      public void initialize(Form1 form){
         base.initialize(form);
         if(manager == null){
            MessageBox.Show("Manager was set to null. Continuous loop.");
            while(true){}
         }
         createLabels(manager.getProjects());
      }

      public void clear(){
         while(projectDescriptionLabel.Any()){
            removeControlFromWindow(projectDescriptionLabels[0]);
            projectDescriptionLabels.RemoveAt(0);
         }
         while(projectNameLabels.Any()){
            removeControlFromWindow(projectNameLabels[0]);
            projectNameLabels.RemoveAt(0);
         }
         while(projectNumberOfLinesLabels.Any()){
            removeControlFromWindow(projectNameLabels[0]);
            projectNameLabels.RemoveAt(0);
         }
         setWindow(null);
      }

      public ClickResults handleClick(int x, int y){
         var results = new ClickResults();
         results.setShouldClose(false);
         return results;
      }

      public createLabels(List<CodingProject> projects){
         for(int i = 0; i < projects.Count; i++){
            // create name label
            Label name = new Label();
            name.AutoSize = true;
            name.Location = new Point(12, 40 + i * 30);
            name.ForeColor = System.Drawing.Color.RoyalBlue;
            name.Size = new Size(70, 13);
            name.Text = project.getName();
            // create descriptions label
            Label description = new Label();
            descriptions.AutoSize = true;
            descriptions.Location = new Point(100, 40 + i * 30);
            descriptions.ForeColor = System.Drawing.Color.RoyalBlue;
            descriptions.Size = new Size(70, 13);
            descriptions.Text = project.getDescription();
            // create number of lines label
            Label numberOfLines = new Label();
            numberOfLines.AutoSize = true;
            numberOfLines.Location = new Point(12, 52 + i * 30);
            numberOfLines.ForeColor = System.Drawing.Color.RoyalBlue;
            numberOfLines.Size = new Size(70, 13);
            numberOfLines.Text = project.getLinesOfCode().ToString();
            projectNameLabels.Add(name);
            projectDescriptionLabels.Add(description);
            projectNumberOfLinesLabels.Add(numberOfLines);
            addControlToWindow(name);
            addControlToWindow(description);
            addControlToWindow(numberOfLines);
         }
      }

      // getter methods
      public CodingProjectsManager getManager() { return manager; }

      // setter methods
      public void setManager(CodingProjectsManager param) { manager = param; }
   }
}
