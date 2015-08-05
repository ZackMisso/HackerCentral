using System.Text;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.School {
   public class SchoolGoal : Goal{
      private List<SchoolClass> classes;
      private List<int> classIDs;
      private List<SchoolGradeContainer> containers;
      private List<int> containerIDs;
      private List<float> goalAverages;
      private bool byClass; // else by containers

      public override void updateGoal(object obj) {
         throw new System.NotImplementedException();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("SchoolGoal" + "^");
         sb.Append(getGoalID() + "^");
         if (getStatus() == GoalStatusEnum.None)
            sb.Append("None" + "^");
         if (getStatus() == GoalStatusEnum.NotStarted)
            sb.Append("Not Started" + "^");
         if (getStatus() == GoalStatusEnum.InProgress)
            sb.Append("In Progress" + "^");
         if (getStatus() == GoalStatusEnum.Succeeded)
            sb.Append("Succeeded" + "^");
         if (getStatus() == GoalStatusEnum.Failed)
            sb.Append("Failed" + "^");
         sb.Append(getName() + "^");
         sb.Append(getPercentAccomplished().ToString() + "^");
         sb.Append(classes.Count.ToString() + "^");
         foreach (SchoolClass clas in classes)
            sb.Append(clas.getClassID() + "^");
         sb.Append(containers.Count.ToString() + "^");
         foreach (SchoolGradeContainer container in containers)
            sb.Append(container.getContainerID() + "^");
         sb.Append(goalAverages.Count.ToString() + "^")
         foreach (float average in goalAverages)
            sb.Append(average.ToString() + "^");
         sb.Append(byClass + "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public List<SchoolClass> getClasses() { return classes; }
      public List<int> getClassIDs() { return classIDs; }
      public List<SchoolGradeContainer> getContainers() { return containers; }
      public List<int> getGoalAverges() { return goalAverages; }
      public List<float> getGoalAverages() { return goalAverages; }
      public bool getByClass() { return byClass; }

      // setter methods
      public void setClasses(List<SchoolClass> param) { classes = param; }
      public void setClassIDs(List<int> param) { classIDs = param; }
   }
}
