using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicManager : Manager{
      private List<MusicPiece> pieces;
      private List<MusicTask> tasks;
      private List<MusicGoal> goals;
      private MusicIO io;
      private int nextPieceID;
      private int nextTaskID;
      private int nextGoalID;

      public MusicManager(){
         pieces = new List<MusicPiece>();
         tasks = new List<MusicTask>();
         goals = new List<MusicGoal>();
      }

      public void initialize() {
         // Read in IDs
         pieces = io.readPiecesFromFiles;
         tasks = io.readTasksFromFile;
         goals = io.readGoalsFromFiles;
         match();
      }

      public void match() {
         // implement mixing
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<MusicPiece> getPieces() { return pieces; }
      public List<MusicTask> getTasks() { return tasks; }
      public List<MusicGoal> getGoals() { return goals; }
      public IO getIO() { return io; }
      public int getNextPieceID() { return nextPieceID; }
      public int getNextTaskID() { return nextTaskID; }
      public int getNextGoalID() { return nextGoalID; }

      // setter methods
      public void setPieces(List<MusicPiece> param) { pieces = param; }
      public void setTasks(List<MusicTask> param) { tasks = param; }
      public void setGoals(List<MusicGoal> param) { goals = param; }
      public void setIO(MusicIO param) { io = param; }
      public void setNextPieceID(int param) { nextPieceID = param; }
      public void setNextTaskID(int param) { nextTaskID = param; }
      public void setNextGoalID(int param) { nextGoalID = param; }
   }
}
