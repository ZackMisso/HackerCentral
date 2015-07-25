using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using HackerCentral.Common;
using HackerCentral.Common.Enum;

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
      private List<ComboBox> statusBoxes;
      private Button acceptChanges;
      private Button nextPage;
      private Button prevPage;
      private int currentPage;
      private int itemsPerPage;
      private int maxPage;

      public CodingProjectsTasksPanel() : base(){
         descriptionLabels = new List<Label>();
         projectNameLabels = new List<Label>();
         nameLabels = new List<Label>();
         effortLabels = new List<Label>();
         taskDescriptionLabels = new List<Label>();
         taskProjectNameLabels = new List<Label>();
         taskNameLabels = new List<Label>();
         taskEffortLabels = new List<Label>();
         statusLabels = new List<Label>();
         statusBoxes = new List<ComboBox>();
         currentPage = 0;
         itemsPerPage = 0;
         maxPage = 0;
      }

      public void initialize(Form1 form) {
         base.initialize(form);
         createLabels(((CodingProjectsManager)getManager()).getTasks());
         acceptChanges = createButton(new Point(115, 500), new Size(70, 30), "Save");
         acceptChanges.Click += new System.EventHandler(save);
         nextPage = createButton(new Point(200, 500), new Size(20, 30), ">");
         nextPage.Click += new System.EventHandler(nextPageClick);
         prevPage = createButton(new Point(80, 500), new Size(20, 30), "<");
         prevPage.Click += new System.EventHandler(prevPageClick);
         addControlToWindow(acceptChanges);
         addControlToWindow(nextPage);
         addControlToWindow(prevPage);
         currentPage = 0;
         itemsPerPage = 8;
         maxPage = statucLabels.Count%8 == 0 ? statusLabels.Count/8 : statusLabels.Count / 8 + 1;
      }

      public void nextPageClick(object sender, EventArgs e) {
         if (currentPage != maxPage)
            currentPage++;
         // TODO :: redraw the list
      }

      public void prevPageClick(object sender, EventArgs e) {
         if (currentPage != 0)
            currentPage--;
         // TODO :: redraw the list
      }

      public void save(object sender, EventArgs e) {
         var list = ((CodingProjectsManager)getManager()).getTasks();
         for (int i = 0; i < itemsPerPage; i++) {
            var task = list[i + currentPage * itemsInPage];
            var status = statusLabels[i + currentPage * itemsInPage].Text;
            if (status.Equals("To Do"))
               task.setStatus(TaskStatusEnum.ToDo);
            else if (status.Equals("Canceled"))
               task.setStatus(TaskStatusEnum.Canceled);
            else if (status.Equals("Done"))
               task.setStatus(TaskStatusEnum.Done);
            else if (status.Equals("Failed"))
               task.setStatus(TaskStatusEnum.Failed);
            else if (status.Equals("In Progress"))
               task.setStatus(TaskStatusEnum.InProgress);
         }
         ((CodingProjectsIO)getIO()).writeTasksToFiles(list);
      }

      public override void clear() {
         removeControlFromWindow(acceptChanges);
         removeControlFromWindow(nextPage);
         removeControlFromWindow(prevPage);
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
            Label description = createLabel(new Point(12, 55 + i * 60), new Size(70, 13), "Description:");
            // create project name label
            Label projectName = createLabel(new Point(12, 70 + i * 60), new Size(70, 13), "Project Name:");
            // create name label
            Label name = createLabel(new Point(12, 40 + i * 60), new Size(70, 13), "Name:");
            // create effort label1
            Label effort = createLabel(new Point(560, 40 + i * 60), new Size(70, 13), "Effort:");
            // create task description labels
            Label taskDescription = createLabel(new Point(100, 55 + i * 60), new Size(70, 13), tasks[i].getDescription());
            // create task project name labels
            Label taskProjectName = createLabel(new Point(100, 70 + i * 60), new Size(70, 13), tasks[i].getProject().getName());
            // create task name label
            Label taskName = createLabel(new Point(100, 40 + i * 60), new Size(70, 13), tasks[i].getName());
            // create task effort level label
            Label taskEffort = createLabel(new Point(600, 40 + i * 60), new Size(70, 13), tasks[i].getEffort().ToString());
            // create status labels
            Label status = createLabel(new Point(560, 70 + i * 60), new Size(70, 13), "Status:");
            // create status boxes
            ComboBox statusBox = createComboBox(new Point(650, 70 + i * 60), new Size(100, 80));
            statusBox.Items.Add("To Do");
            statusBox.Items.Add("Canceled");
            statusBox.Items.Add("Done");
            statusBox.Items.Add("Failed");
            statusBox.Items.Add("In Progress");
            if(tasks[i].getStatus() == TaskStatusEnum.ToDo){
               statusBox.SelectedIndex = 0;
            }else if(tasks[i].getStatus() == TaskStatusEnum.Canceled){
               statusBox.SelectedIndex = 1;
            }else if(tasks[i].getStatus() == TaskStatusEnum.Done){
               statusBox.SelectedIndex = 2;
            }else if(tasks[i].getStatus() == TaskStatusEnum.Failed){
               statusBox.SelectedIndex = 3;
            }else if(tasks[i].getStatus() == TaskStatusEnum.InProgress){
               statusBox.SelectedIndex = 4;
            }
            // add items to window
            descriptionLabels.Add(description);
            projectNameLabels.Add(projectName);
            nameLabels.Add(name);
            effortLabels.Add(effort);
            taskDescriptionLabels.Add(taskDescription);
            taskProjectNameLabels.Add(taskProjectName);
            taskNameLabels.Add(taskName);
            taskEffortLabels.Add(taskEffort);
            statusLabels.Add(status);
            statusBoxes.Add(statusBox);
         }
      }
   }
}
