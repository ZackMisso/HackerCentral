using System.Collections.Generic;
using HackerCentral.Common;

using System.Linq;

namespace HackerCentral.Art {
   public class ArtManager : Manager{
      private List<ArtPiece> pieces;
      private List<ArtTask> tasks;
      private List<ArtGoal> goals;
      private ArtIO io;
      private int nextPieceID;
      private int nextTaskID;
      private int nextGoalID;

      public ArtManager() {
         pieces = new List<ArtPiece>();
         tasks = new List<ArtTask>();
         goals = new List<ArtGoal>();
      }

      public void initialize() {
         // Read in IDs
         pieces = io.readPiecesFromFiles();
         tasks = io.readTasksFromFiles();
         goals = io.readGoalsFromFiles();
         match();
      }

      public void match() {
         // no matching needs to be done for ArtPiece
         foreach (ArtTask task in tasks)
            task.setPiece(pieces.SingleOrDefault(x => x.getPieceID() == task.getPieceID()));
         foreach (ArtGoal goal in goals)
            goal.setTasks(tasks.Where(x => goal.getTaskIDs().Contains(x.getTaskID())));
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<ArtPiece> getPieces() { return pieces; }
      public List<ArtTask> getTasks() { return tasks; }
      public List<ArtGoal> getGoals() { return goals; }
      public IO getIO() { return io; }
      public int getNextPieceID() { return nextPieceID; }
      public int getNextTaskID() { return nextTaskID; }
      public int getNextGoalID() { return nextGoalID; }

      // setter methods
      public void setPieces(List<ArtPiece> param) { pieces = param; }
      public void setTasks(List<ArtTask> param) { tasks = param; }
      public void setGoals(List<ArtGoal> param) { goals = param; }
      public void setIO(ArtIO param) { io = param; }
      public void setNextPieceID(int param) { nextPieceID = param; }
      public void setNextTaskID(int param) { nextTaskID = param; }
      public void setNextGoalId(int param) { nextGoalID = param; }
   }
}
