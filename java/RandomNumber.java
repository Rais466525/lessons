import java.lang.Math;
import java.util.Scanner;

class RandomNumber {
    public static void main(String args[]) {
         int max = 10;
         int min = 1;
         int range = max - min + 1;
         int num;

         System.out.println("Enter the integer: ");
         Scanner s = new Scanner(System.in);
         num = s.nextInt();

         for (int i = 0; i < 10; i++) {
            int rundomNumber = (int)(Math.random() * range) + min;
         
         System.out.println("Деление");
         System.out.println(rundomNumber/num);
         System.out.println("Минус");
         System.out.println(rundomNumber-num);
         System.out.println("Плюс");
         System.out.println(rundomNumber+num);
         System.out.println("умножение");
         System.out.println(rundomNumber*num);

         s.close();
      }
   }
}