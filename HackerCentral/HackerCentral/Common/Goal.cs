using HackerCentral.Common.Enum;

namespace HackerCentral.Common {
   public abstract class Goal {
      private GoalStatusEnum status;
      private float percentAccomplished;

      public Goal() {
         // to be implemented
      }

      public abstract void updateGoal(object obj);

      // getter methods
      public GoalStatusEnum getStatus() { return status; }
      public float getPercentAccomplished() { return percentAccomplished; }

      // setter methods
      public void setStatus(GoalStatusEnum param) { status = param; }
      public void setPercentAccomplished(float param) { percentAccomplished = param; }
   }
}
