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
         // to be implemented
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
