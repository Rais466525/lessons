import java.util.Scanner;

public class IfElse {
   public static void main(String[] args) {
      
      System.out.println("введите возраст: ");
      Scanner scanner = new Scanner(System.in);
      int number = scanner.nextInt();

      if (number >18) {
         System.out.println("можно курить");
      } else if (number <18) {
         System.out.println("нельзя курить");
      } else {
         System.out.println("такого возраста нет");
      }
   }
}