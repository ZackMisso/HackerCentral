using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsListOfProjectsPanel : CustomPanel{
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
         createLabels(((CodingProjectsManager)getManager()).getProjects());
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

      public void createLabels(List<CodingProject> projects){
         for(int i = 0; i < projects.Count; i++){
            // create name label
            Label name = createLabel(new Point(12, 40 + i * 30), new Size(70, 13), projects[i].getName());
            // create descriptions label
            Label description = createLabel(new Point(100, 40 + i * 30), new Size(70, 13), projects[i].getDescription());
            // create number of lines label
            Label numberOfLines = createLabel(new Point(12, 52 + i * 30), new Size(70, 13), projects[i].getLinesOfCode().ToString());
            // add items to window
            projectNameLabels.Add(name);
            projectDescriptionLabels.Add(description);
            projectNumberOfLinesLabels.Add(numberOfLines);
         }
      }
   }
}
