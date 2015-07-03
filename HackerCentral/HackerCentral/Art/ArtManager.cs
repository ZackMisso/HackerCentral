using System.Collections.Generic;
using HackerCentral.Common;

namespace HackerCentral.Art {
   public class ArtManager : Manager{
      private List<ArtPiece> pieces;
      private List<ArtTask> tasks;
      private List<ArtGoal> goals;
      private ArtIO io;

      public ArtManager() {
         pieces = new List<ArtPiece>();
         tasks = new List<ArtTask>();
         goals = new List<ArtGoal>();
      }

      public void initialize() {
         // to be implemented
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<ArtPiece> getPieces() { return pieces; }
      public List<ArtTask> getTasks() { return tasks; }
      public List<ArtGoal> getGoals() { return goals; }
      public IO getIO() { return io; }

      // setter methods
      public void setPieces(List<ArtPiece> param) { pieces = param; }
      public void setTasks(List<ArtTask> param) { tasks = param; }
      public void setGoals(List<ArtGoal> param) { goals = param; }
      public void setIO(ArtIO param) { io = param; }
   }
}
