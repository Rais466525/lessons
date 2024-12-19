import java.util.Scanner;

public class StudentChairChecker {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите количество студентов: ");
        int numberOfStudents = scanner.nextInt();
        
        System.out.print("Введите количество мест: ");
        int numberOfChairs = scanner.nextInt();

        if (numberOfChairs > numberOfStudents) {
            System.out.println("Количество мест больше, чем количество студентов");
            System.out.println("Мест хватает");
        } 
        
        else if (numberOfChairs == numberOfStudents) {
            System.out.println("Количество мест равно количеству студентов");
            System.out.println("Мест хватает");
        } 
        
        else {
            System.out.println("Мест не хватает");
        }

        scanner.close();
    }
}