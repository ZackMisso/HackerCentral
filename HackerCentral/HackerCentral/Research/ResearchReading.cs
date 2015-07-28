﻿using System.Text;
using System.Collections.Generic;

namespace HackerCentral.Research {
   public class ResearchReading {
      private List<ResearchReadingTask> tasks;
      private List<ResearchReadingsGoal> goals;
      private List<int> goalIDs;
      private List<int> taskIDs;
      private string path;
      private string notesPath;
      private int pagesRead;
      private int totalPages;
      private bool isFile;
      private bool isUrl;
      private bool done;

      public ResearchReading() {
         tasks = new List<ResearchReadingTask>();
         goals = new List<ResearchReadingsGoal>();
         goalIDs = new List<int>();
         taskIDs = new List<int>();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         // to be implemented
         return sb.ToString();
      }

      // getter methods
      public List<ResearchReadingTask> getTasks() { return tasks; }
      public List<ResearchReadingsGoal> getGoals() { return goals; }
      public List<int> getGoalIDs() { return goalIDs; }
      public List<int> getTaskIDs() { return taskIDs; }
      public string getPath() { return path; }
      public string getNotesPath() { return notesPath; }
      public int getPagesRead() { return pagesRead; }
      public int getTotalPages() { return totalPages; }
      public bool getIsFile() { return isFile; }
      public bool getIsUrl() { return isUrl; }
      public bool getDone() { return done; }

      // setter methods
      public void setTasks(List<ResearchReadingTask> param) { tasks = param; }
      public void setGoals(List<ResearchReadingsGoal> param) { goals = param; }
      public void setGoalIDs(List<int> param) { goalIDs = param; }
      public void setTaskIDs(List<int> param) { taskIDs = param; }
      public void setPath(string param) { path = param; }
      public void setNotesPath(string param) { notesPath = param; }
      public void setPagesRead(int param) { pagesRead = param; }
      public void setTotalPages(int param) { totalPages = param; }
      public void setIsFile(bool param) { isFile = param; }
      public void setIsUrl(bool param) { isUrl = param; }
      public void setDone(bool param) { done = param; }
   }
}
