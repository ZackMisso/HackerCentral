using System.Text;
using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessTask : Task{
      private FitnessExercise exercise;
      private int exerciseID;
      private int reps;
      private bool daily;
      private bool weekly;
      private bool monthly;

      public string public override string ToString(){
         var sb = new StringBuilder();
         sb.Append("FitnessTask" + "^");
         sb.Append(exerciseID.ToString() + "^");
         sb.Append(reps.ToString() + "^");
         sb.Append(daily + "^");
         sb.Append(weekly + "^");
         sb.Append(monthly + "^");
         sb.Append(getName() + "^");
         sb.Append(getTaskID().ToString() + "^");
         sb.Append(getEffort().ToString() + "^");
         if (getStatus() == TaskStatusEnum.ToDo)
            sb.Append("To Do" + "^");
         if (getStatus() == TaskStatusEnum.InProgress)
            sb.Append("In Progress" + "^");
         if (getStatus() == TaskStatusEnum.Done)
            sb.Append("Done" + "^");
         if (getStatus() == TaskStatusEnum.Canceled)
            sb.Append("Canceled" + "^");
         if (getStatus() == TaskStatusEnum.Failed)
            sb.Append("Failed" + "^");
         sb.Append(getDescription() "^");
         sb.Append("\n");
         return sb.ToString();
      }

      // getter methods
      public FitnessExercise getFitnessExercise() { return exercise; }
      public int getExerciseID() { return exerciseID; }
      public int getReps() { return reps; }
      public bool getDaily() { return daily; }
      public bool getMonthly() { return monthly; }
      public bool getWeekly() { return weekly; }

      // setter methods
      public void setFitnessExercise(FitnessExercise param){exercise = param;}
      public void setExerciseID(int param){exerciseID = param;}
      public void setReps(int param) { reps = param; }
      public void setDaily(bool param) { daily = param; }
      public void setWeekly(bool param) { weekly = param; }
      public void setMonthly(bool param) { monthly = param; }
   }
}
