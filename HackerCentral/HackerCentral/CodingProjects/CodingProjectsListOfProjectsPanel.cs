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

      public void initialize(Form1 form) {
         base.initialize(form);
         if(manager == null){
            MessageBox.Show("Manager was set to null. Continuous loop.");
            while(true){}
         }
         createLabels(manager.getProjects());
      }

      public override void clear() {
         while(projectDescriptionLabels.Count > 0){
            removeControlFromWindow(projectDescriptionLabels[0]);
            projectDescriptionLabels.RemoveAt(0);
         }
         while(projectNameLabels.Count > 0){
            removeControlFromWindow(projectNameLabels[0]);
            projectNameLabels.RemoveAt(0);
         }
         while(projectNumberOfLinesLabels.Count > 0){
            removeControlFromWindow(projectNameLabels[0]);
            projectNameLabels.RemoveAt(0);
         }
         setWindow(null);
      }

      public override ClickResults handleClick(int x, int y) {
         var results = new ClickResults();
         results.setShouldClose(false);
         return results;
      }

      public override void handleResults(ResultHandler handler) {
         // to be implemented
      }

      public void createLabels(List<CodingProject> projects){
         for(int i = 0; i < projects.Count; i++){
            // create name label
            Label name = new Label();
            name.AutoSize = true;
            name.Location = new Point(12, 40 + i * 30);
            name.ForeColor = System.Drawing.Color.RoyalBlue;
            name.Size = new Size(70, 13);
            name.Text = projects[i].getName();
            // create descriptions label
            Label description = new Label();
            description.AutoSize = true;
            description.Location = new Point(100, 40 + i * 30);
            description.ForeColor = System.Drawing.Color.RoyalBlue;
            description.Size = new Size(70, 13);
            description.Text = projects[i].getDescription();
            // create number of lines label
            Label numberOfLines = new Label();
            numberOfLines.AutoSize = true;
            numberOfLines.Location = new Point(12, 52 + i * 30);
            numberOfLines.ForeColor = System.Drawing.Color.RoyalBlue;
            numberOfLines.Size = new Size(70, 13);
            numberOfLines.Text = projects[i].getLinesOfCode().ToString();
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
