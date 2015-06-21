using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackerCentral.Common;
using HackerCentral.Art;
using HackerCentral.Behavioral;
using HackerCentral.CodingProjects;
using HackerCentral.Fitness;
using HackerCentral.Home;
using HackerCentral.Music;
using HackerCentral.Research;
using HackerCentral.School;
using HackerCentral.Settings;

namespace HackerCentral {
   public partial class Form1 : Form {
      private GlobalManager globalManager;
      private GlobalIO globalIO;
      private Manager currentManager;
      private IO currentIO;
      private CustomPanel view;

      public Form1() {
         InitializeComponent();
         globalManager = new GlobalManager();
         globalIO = new GlobalIO();
         globalManager.initializeAllIO(globalIO);
      }

      //protected override void OnMouseDown(MouseEventArgs e) {
     //    base.OnMouseDown(e);
      //   // to be implemented
       //  int num = 0;
      ///}

      //protected override void OnMouseClick(MouseEventArgs e) {
      //   base.OnMouseClick(e);
      //   // to be implemented
      //   int num = 0;
      //}

      //protected override void OnClick(EventArgs e) {
      //   base.OnClick(e);
      //   // to be implemented
      //   int num = 0;
      //}

      private void financesToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void homeToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void tasksToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void historyToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void goalsToolStripMenuItem2_Click(object sender, EventArgs e) {

      }

      private void tasksToolStripMenuItem1_Click(object sender, EventArgs e) {

      }

      private void historyToolStripMenuItem1_Click(object sender, EventArgs e) {

      }

      private void goalsToolStripMenuItem1_Click(object sender, EventArgs e) {

      }

      private void tasksToolStripMenuItem2_Click(object sender, EventArgs e) {

      }

      private void historyToolStripMenuItem2_Click(object sender, EventArgs e) {

      }

      private void goalsToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void currentMonthToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void historyToolStripMenuItem3_Click(object sender, EventArgs e) {

      }

      private void newTransactionToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void tasksToolStripMenuItem3_Click(object sender, EventArgs e) {

      }

      private void historyToolStripMenuItem4_Click(object sender, EventArgs e) {

      }

      private void goalsToolStripMenuItem3_Click(object sender, EventArgs e) {

      }

      private void tasksToolStripMenuItem4_Click(object sender, EventArgs e) {

      }

      private void historyToolStripMenuItem5_Click(object sender, EventArgs e) {

      }

      private void goalsToolStripMenuItem4_Click(object sender, EventArgs e) {

      }

      private void settingsToolStripMenuItem1_Click(object sender, EventArgs e) {

      }

      private void InfoPanel_Paint(object sender, PaintEventArgs e) {
         //System.Windows.Forms.Panel panel = sender as System.Windows.Forms.Panel;
         //System.Drawing.Rectangle rect = panel.ClientRectangle;
         //rect.Width--;
         //rect.Height--;
         //e.Graphics.DrawRectangle(Pens.Black, rect);
      }

      private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void codingProjectsToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void researchToolStripMenuItem_Click(object sender, EventArgs e) {

      }

      private void Form1_Load(object sender, EventArgs e) {

      }

      private void button1_Click(object sender, EventArgs e) {

      }

      private void codingNewProjectItem_Click(object sender, EventArgs e) {
         if(view != null)
            view.clear();
         currentManager = globalManager.getCodingProjectsManager();
         currentIO = currentManager.getIO();
         view = new CodingProjectsNewProjectPanel();
         ((CodingProjectsNewProjectPanel)view).initialize(this);
      }

      private void codingProjectsNewTaskItem_Click(object sender, EventArgs e) {
         if (view != null)
            view.clear();
         currentManager = globalManager.getCodingProjectsManager();
         currentIO = currentManager.getIO();
         view = new CodingProjectsAddTaskPanel();
         ((CodingProjectsAddTaskPanel)view).initialize(this);
      }

      private void codingListOfProjectsItem_Click(object sender, EventArgs e) {
         if (view != null)
            view.clear();
         currentManager = globalManager.getCodingProjectsManager();
         currentIO = currentManager.getIO();
         view = new CodingProjectsListOfProjectsPanel();
         ((CodingProjectsListOfProjectsPanel)view).initialize(this);
      }

      // getter methods
      public Manager getCurrentManager() { return currentManager; }
      public IO getCurrentIO() { return currentIO; }
   }
}
