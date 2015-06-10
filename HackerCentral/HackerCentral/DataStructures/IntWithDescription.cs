namespace HackerCentral.DataStructures {
   public class IntWithDescription {
      private string description;
      private int value;

      public IntWithDescription(int val,string desc) {
         description = desc;
         value = val;
      }

      // getter methods
      public int getValue() { return value; }
      public string getDescription() { return description; }

      // setter methods
      public void setValue(int val) { value = val; }
      public void setDescription(string val) { description = val; }
   }
}
