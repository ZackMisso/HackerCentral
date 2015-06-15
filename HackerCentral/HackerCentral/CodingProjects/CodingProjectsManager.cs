using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.CodingProjects {
   public class CodingProjectsManager : Manager{
      private List<CodingProject> projects;
      private List<CodingProjectsTask> tasks;
      private List<CodingProjectsGoal> goals;
      private CodingProjectsIO io;
      private int nextProjectID;
      private int nextTaskID;
      private int nextGoalID;

      public CodingProjectsManager() {
         projects = new List<CodingProject>();
         tasks = new List<CodingProjectsTask>();
         goals = new List<CodingProjectsGoal>();
         io = null;
      }

      public void initialize() {
         projects = io.readCodingProjectsFromFile();
      }

      public void update() {
         // to be implemented
      }

      public void addNewCodingProject(CodingProject project) {
         project.setProjectID(nextProjectID++);
         projects.Add(project);
      }

      public void addNewCodingTask(CodingProjectsTask task) {
         task.setTaskID(nextTaskID++);
         tasks.Add(task);
      }

      public void addNewCodingGoal(CodingProjectsGoal goal) {
         goal.setGoalID(nextGoalID);
         goals.Add(goal);
      }

      // getters
      public List<CodingProject> getProjects() { return projects; }
      public int getNextProjectID() { return nextID; }
      public int getNextTaskID() { return nextTaskID; }
      public int getNextGoalID() { return nextGoalID; }

      // setters
      public void setProjects(List<CodingProject> param) { projects = param; }
      public void setIO(CodingProjectsIO param) { io = param; }
   }
}
