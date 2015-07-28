using HackerCentral.Common;

namespace HackerCentral.Music {
   public class MusicManager : Manager{
      private List<MusicPiece> pieces;
      private List<MusicTask> tasks;
      private List<MusicGoal> goals;
      private MusicIO io;

      public MusicManager(){
         pieces = new List<MusicPiece>();
         tasks = new List<MusicTask>();
         goals = new List<MusicGoal>();
      }

      public void initialize() {
         // to be implemented
      }

      public void update() {
         // to be implemented
      }

      // getter methods
      public List<MusicPiece> getPieces() { return pieces; }
      public List<MusicTask> getTasks() { return tasks; }
      public List<MusicGoal> getGoals() { return goals; }
      public IO getIO() { return io; }

      // setter methods
      public void setPieces(List<MusicPiece> param) { pieces = param; }
      public void setTasks(List<MusicTask> param) { tasks = param; }
      public void setGoals(List<MusicGoal> param) { goals = param; }
      public void setIO(MusicIO param) { io = param; }
   }
}
