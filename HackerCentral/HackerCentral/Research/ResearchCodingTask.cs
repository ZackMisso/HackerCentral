using System;
using HackerCentral.CodingProjects;

namespace HackerCentral.Research {
   public class ResearchCodingTask : ResearchTask{
      private CodingProject project;
      private CodingProjectsTask projectTask;
      private int projectID;
      private int projectTaskID;

      public ResearchCodingTask() {}

      public string toString() {
         StringBuilder sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public CodingProject getProject() { return project; }
      public CodingProjectsTask getProjectTask() { return projectTask; }
      public int getProjectID() { return projectID; }
      public int getProjectTaskID() { return projectTaskID; }

      // setter methods
      public void setProject(CodingProject param) { project = param; }
      public void setProjectTask(CodingProjectsTask param) { projectTask = param; }
      public void setProjectID(int param) { projectID = param; }
      public void setProjectTaskID(int param) { projectTaskID = param; }
   }
}
