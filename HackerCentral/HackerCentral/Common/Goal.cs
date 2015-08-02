using HackerCentral.Common.Enum;

namespace HackerCentral.Common {
   public abstract class Goal {
      private string name;
      private GoalStatusEnum status;
      private float percentAccomplished;
      private int goalID;

      public Goal() {
         status = GoalStatusEnum.None;
         percentAccomplished = 0.0f;
         goalID = -1;
      }

      public abstract void updateGoal(object obj);

      // getter methods
      public string getName() { return name; }
      public GoalStatusEnum getStatus() { return status; }
      public float getPercentAccomplished() { return percentAccomplished; }
      public int getGoalID() { return goalID; }

      // setter methods
      public void setName(string param) { name = param; }
      public void setStatus(GoalStatusEnum param) { status = param; }
      public void setPercentAccomplished(float param) { percentAccomplished = param; }
      public void setGoalID(int param) { goalID = param; }
   }
}
