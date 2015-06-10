namespace HackerCentral.DataStructures {
   public class DoubleWithDescription {
      private string description;
      private double value;

      public IntWithDescription(double val,string desc) {
         description = desc;
         value = val;
      }

      // getter methods
      public double getValue() { return value; }
      public string getDescription() { return description; }

      // setter methods
      public void setValue(double val) { value = val; }
      public void setDescription(string val) { description = val; }
   }
}
