﻿using System;
using System.Text;
using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessExercise : Task{
      private FitnessExerciseGoal goal;
      private DateTime startTime;
      private string name;
      private int totalReps;
      private int goalID;
      private int exerciseID;
      private bool hasGoal;
      private bool updatesPerWeek;
      private bool updatesPerMonth;

      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append(exerciseID.ToString() + "^");
         sb.Append(goalID.ToString() + "^");
         sb.Append(name + "^");
         sb.Append(totalReps.ToString() + "^");
         sb.Append(hasGoal + "^");
         sb.Append(updatesPerWeek + "^");
         sb.Append(updatesPerMonth + "^");
         sb.Append("\n")
         return sb.ToString();
      }
      
      // getter methods
      public FitnessExerciseGoal getGoal() { return goal; }
      public DateTime getStartTime() { return startTime; }
      public string getName() { return name; }
      public int getTotalReps() { return totalReps; }
      public int getExerciesID() { return exerciseID; }
      public int getGoalID() { return goalID; }
      public bool getHasGoal() { return hasGoal; }
      public bool getUpdatesPerWeek() { return updatesPerWeek; }
      public bool getUpdatesPerMonth() { return updatesPerMonth; }

      // setter methods
      public void setGoal(FitnessExerciseGoal param) { goal = param; }
      public void setStartTime(DateTime param) { startTime = param; }
      public void setName(string param) { name = param; }
      public void setTotalReps(int param) { totalReps = param; }
      public void setExerciseID(int param) { exerciseID = param; }
      public void setGoalID(bool param) { goalID = param; }
      public void setHasGoal(bool param) { hasGoal = param; }
      public void setUpdatesPerWeek(bool param) { updatesPerWeek = param; }
      public void setUpdatesPerMonth(bool param) { updatesPerMonth = param; }
   }
}
