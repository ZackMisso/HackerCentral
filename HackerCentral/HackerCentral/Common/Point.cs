namespace HackerCentral.Common {
   public class Point {
      private int xpos;
      private int ypos;

      public Point() {
         x = 0;
         y = 0;
      }

      public Point(int x, int y) {
         xpos = x;
         ypos = y;
      }

      // getter methods
      public int getXpos() { return xpos; }
      public int getYpos() { return ypos; }

      // setter methods
      public void setXpos(int x) { xpos = x; }
      public void setYpos(int y) { ypos = y; }
   }
}
