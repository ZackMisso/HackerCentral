using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsListOfProjectsPanel : CustomPanel{
      private List<Label> descriptionLabels;
      private List<Label> nameLabels;
      private List<Label> numberOfLinesLabels;
      private List<Label> projectDescriptionLabels;
      private List<Label> projectNameLabels;
      private List<Label> projectNumberOfLinesLabels;

      public CodingProjectsListOfProjectsPanel() : base() {
         descriptionLabels = new List<Label>();
         nameLabels = new List<Label>();
         numberOfLinesLabels = new List<Label>();
         projectDescriptionLabels = new List<Label>();
         projectNameLabels = new List<Label>();
         projectNumberOfLinesLabels = new List<Label>();
      }

      public void initialize(Form1 form) {
         base.initialize(form);
         createLabels(((CodingProjectsManager)getManager()).getProjects());
      }

      public override void clear() {
         while(descriptionLabels.Count > 0){
            removeControlFromWindow(descriptionLabels[0]);
            descriptionLabels.RemoveAt(0);
         }
         while(nameLabels.Count > 0){
            removeControlFromWindow(nameLabels[0]);
            nameLabels.RemoveAt(0);
         }
         while(numberOfLinesLabels.Count > 0){
            removeControlFromWindow(numberOfLinesLabels[0]);
            numberOfLinesLabels.RemoveAt(0);
         }
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
            Label name = createLabel(new Point(12, 40 + i * 30), new Size(70, 13), "Name:");
            // create descriptions label
            Label description = createLabel(new Point(100, 40 + i * 30), new Size(70, 13), "Description:");
            // create number of lines label
            Label numberOfLines = createLabel(new Point(12, 52 + i * 30), new Size(70, 13), "Lines of Code:");
            // create project name label
            Label projectName = createLabel(new Point(82, 40 + i * 30), new Size(70, 13), projects[i].getName());
            // create descriptions label
            Label projectDescription = createLabel(new Point(180, 40 + i * 30), new Size(70, 13), projects[i].getDescription());
            // create number of lines label
            Label projectNumberOfLines = createLabel(new Point(82, 52 + i * 30), new Size(70, 13), projects[i].getLinesOfCode().ToString());
            // add items to window
            projectNameLabels.Add(name);
            projectDescriptionLabels.Add(description);
            projectNumberOfLinesLabels.Add(numberOfLines);
            projectNameLabels.Add(projectName);
            projectDescriptionLabels.Add(projectDescription);
            projectNumberOfLinesLabels.Add(projectNumberOfLines);
         }
      }
   }
}
