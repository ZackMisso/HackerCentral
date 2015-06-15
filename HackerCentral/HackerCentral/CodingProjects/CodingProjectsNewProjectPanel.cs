using System.Windows.Forms;
using HackerCentral.Common;
using HackerCentral.Common.Enum;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsNewProjectPanel : CustomPanel{
      private TextBox nameBox;
      private TextBox descriptionBox;
      private Label path;
      private Label nameLabel;
      private Label descriptionLabel;
      private Button submitButton;

      public CodingProjectsNewProjectPanel()
         : base() {
         // does nothing
      }

      public void initialize(Form1 form){
         base.initialize(form);
         // create the name box
         nameBox = new TextBox();
         nameBox.Location = new System.Drawing.Point(100, 60);
         nameBox..Size = new System.Drawing.Size(100, 20);
         // create the description box
         descriptionBox = new TextBox();
         descriptionBox.Location = new System.Drawing.Point(100, 80);
         descriptionBox.Size = new System.Drawing.Size(200, 60);
         // create the submit button
         submitButton = new Button();
         submitButton.Location = new System.Drawing.Point(100, 150);
         submitButton.Size = new System.Drawing.Size(75, 23);
         submitButton.Text = "Submit";
         submitButton.UseVisualStyleBackColor = true;
         // create the url label
         path = new Label();
         path.AutoSize = true;
         path.Location = new Point(15, 40);
         path.ForeColor = System.Drawing.Color.RoyalBlue;
         path.Size = new Size(70, 13);
         path.Text = "";
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
         descriptionLabel.Location = new Point(15, 80);
         descriptionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
         descriptionLabel.Size = new Size(70, 13);
         descriptionLabel.Text = "Enter Project Description: ";
         addControlToWindow(nameBox);
         addControlToWindow(descriptionBox);
         addControlToWindow(submitButton);
         addControlToWindow(path);
         addControlToWindow(nameLabel);
         addControlToWindow(descriptionLabel);
      }

      public ClickResults handleClick(int x, int y){
         ClickResults results = new ClickResults();
         if (wasControlClicked(submitButton)) {
            if (!String.IsNullOrWhiteSpace(nameBox.Text) && !String.IsNullOrWhiteSpace(descriptionBox.Text)) {
               results.setRequestManager(true);
               results.setResultToHandle(ResultToHandleEnum.CreatedNewCodingProject);
            } else {
               MessageBox.Show("Invalid Input Information");
            }
         }
         return results;
      }

      public void handleResults(ResultHandler handler){
         if (handler.getResultToHandle() == ResultToHandle.CreatedNewCodingProject) {
            CodingProjectsManager manager = (CodingProjectsManager)handler.getManager();
            // to be implemented
         }
      }

      public void clear(){
         removeControlFromWindow(nameBox);
         removeControlFromWindow(descriptionBox);
         removeControlFromWindow(submitButton);
         removeControlFromWindow(path);
         removeControlFromWindow(nameLabel);
         removeControlFromWindow(descriptionLabel);
      }
   }
}
