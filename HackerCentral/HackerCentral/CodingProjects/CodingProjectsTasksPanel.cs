using System.Collections.Generic;
using System.Windows.Forms;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsTasksPanel : CustomPanel{
      private List<Label> descriptionLabels;
      private List<Label> projectNameLabels;
      private List<Label> nameLabels;
      private List<Label> effortLabels;
      private List<Label> taskDescriptionLabels;
      private List<Label> taskProjectNameLabels;
      private List<Label> taskNameLabels;
      private List<Label> taskEffortLabels;
      private List<Label> statusLabels;
      private List<ListBox> statusBoxes;
      private Button acceptChanges;

      public CodingProjectsTasksPanel() : base(){
         descriptionLabels = new List<Label>();
         projectNameLabels = new List<Label>();
         nameLabels = new List<Label>();
         effortLabels = new List<Label>();
         taskDescriptionLabels = List<Label>();
         taskProjectNameLabels = List<Label>();
         taskNameLabels = List<Label>();
         taskEffortLabels = List<Label>();
         statusLabels = List<Label>();
         statusBoxes = new List<ListBox>();
      }

      public void initialize(Form1 form) {
         base.initialize(form);
         createLabels(((CodingProjectsManager)getManager()).getTasks());
      }

      public override void clear() {
         while (descriptionLabels.Count > 0) {
            removeControlFromWindow(descriptionLabels[0]);
            descriptionLabels.RemoveAt(0);
         }
         while (projectNameLabels.Count > 0) {
            removeControlFromWindow(projectNameLabels[0]);
            projectNameLabels.RemoveAt(0);
         }
         while (nameLabels.Count > 0) {
            removeControlFromWindow(nameLabels[0]);
            nameLabels.RemoveAt(0);
         }
         while (effortLabels.Count > 0) {
            removeControlFromWindow(effortLabels[0]);
            effortLabels.RemoveAt(0);
         }
         while (statusBoxes.Count > 0) {
            removeControlFromWindow(statusBoxes[0]);
            statusBoxes.RemoveAt(0);
         }
         while (taskDescriptionLabels.Count > 0) {
            removeControlFromWindow(taskDescriptionLabels[0]);
            taskDescriptionLabels.RemoveAt(0);
         }
         while (taskProjectNameLabels.Count > 0) {
            removeControlFromWindow(taskProjectNameLabels[0]);
            taskProjectNameLabels.RemoveAt(0);
         }
         while (taskNameLabels.Count > 0) {
            removeControlFromWindow(taskNameLabels[0]);
            taskNameLabels.RemoveAt(0);
         }
         while (taskEffortLabels.Count > 0) {
            removeControlFromWindow(taskEffortLabels[0]);
            taskEffortLabels.RemoveAt(0);
         }
         while (statusLabels.Count > 0) {
            removeControlFromWindow(statusLabels[0]);
            statusLabels.RemoveAt(0);
         }
         setWindow(null);
      }

      public void createLabels(List<CodingProjectsTask> tasks) {
         for (int i = 0; i < tasks.Count; i++) {
            // create description label
            Label description;
            // create project name label
            Label projectName;
            // create name label
            Label name = createLabel(new Point(12, 40 + i * 30), new Size(70, 13), "Name:");
            // create effort label1
            Label effort;
            // create task description labels
            Label taskDescription;
            // create task project name labels
            Label taskDescriptionName;
            // create status labels
            Label status;
            // create status boxes
            ListBox statusBox;
            // add items to window
            descriptionLabels.Add(description);
            projectNAmeLabels.Add(projectName);
            nameLabels.Add(name);
            effortLabels.Add(effort);
            taskDescriptionLabels.Add(taskDescription);
            //taskProjectNameLabels.Add(taskDescriptionName);
            // Continue FROM HEAR
         }
      }

      //private List<Label> descriptionLabels;
      //private List<Label> projectNameLabels;
      //private List<Label> nameLabels;
      //private List<Label> effortLabels;
      //private List<Label> taskDescriptionLabels;
      //private List<Label> taskProjectNameLabels;
      //private List<Label> taskNameLabels;
      //private List<Label> taskEffortLabels;
      //private List<Label> statusLabels;
      //private List<ListBox> statusBoxes;
   }
}
