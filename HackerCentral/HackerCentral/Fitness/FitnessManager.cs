﻿using HackerCentral.Common;

namespace HackerCentral.Fitness {
   public class FitnessManager : Manager{
      private FitnessIO io;

      public FitnessManager() {
         // to be implemented
      }

      // getter methods
      public IO getIO() { return io; }

      // setter methods
      public void setIO(FitnessIO param) { io = param; }
   }
}
