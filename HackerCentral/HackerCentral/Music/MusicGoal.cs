﻿using System.Text;
using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicGoal : Goal {
      private List<MusicTask> tasks;
      private List<int> taskIDs;
      private MusicPiece piece;
      private int pieceID;
      private int iterations;
      private int startIteration;
      private bool taskGoal;
      private bool iterationsGoal;
      private bool genericIterationsGoal;

      public MusicGoal() {
         tasks = new List<MusicTask>();
         taskIDs = new List<int>();
      }

      public override void updateGoal(object obj) {
         throw new System.NotImplementedException();
      }

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("MusicGoal" + "^");
         sb.Append(getGoalID.ToString() + "^");
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
         sb.Append(pieceID.ToString() + "^");
         sb.Append(iterations.ToString() + "^");
         sb.Append(startIteration.ToString() + "^");
         sb.Append(taskGoal + "^");
         sb.Append(iterationsGoal + "^");
         sb.Append(genericIterationsGoal + "^");
         sb.Append(tasks.Count + "^");
         foreach (MusicTask task in tasks)
            sb.Append(task.getTaskID() + "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public List<MusicTask> getTasks() { return tasks; }
      public List<int> getTaskIDs() { return taskIDs; }
      public MusicPiece getPiece() { return piece; }
      public int getPieceID() { return pieceID; }
      public int getIterations() { return iterations; }
      public int getStartIteration() { return startIteration; }
      public bool getTaskGoal() { return taskGoal; }
      public bool getIterationsGoal() { return iterationsGoal; }
      public bool getGenericIterationsGoal() { return genericIterationsGoal; }

      // setter methods
      public void setTasks(List<MusicTask> param) { tasks = param; }
      public void setTaskIDs(List<int> param) { taskIDs = param; }
      public void setPiece(MusicPiece param) { piece = param; }
      public void setPieceID(int param) { pieceID = param; }
      public void setIterations(int param) { iterations = param; }
      public void setStartIteration(int param) { startIteration = param; }
      public void setTaskGoal(bool param) { taskGoal = param; }
      public void setIterationsGoal(bool param) { iterationsGoal = param; }
      public void setGenericIterationsGoal(bool param) { genericIterationsGoal = param; }
   }
}
