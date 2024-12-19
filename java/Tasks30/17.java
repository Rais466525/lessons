import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите количество учеников: ");
        int numberOfStudents = scanner.nextInt();

        System.out.print("Введите количество стульев: ");
        int numberOfChairs = scanner.nextInt();

        if (numberOfChairs > numberOfStudents) {
            System.out.println((numberOfChairs - numberOfStudents) + " стула лишних");
        } 

        else if (numberOfChairs < numberOfStudents) {
            System.out.println((numberOfStudents - numberOfChairs) + " стула не хватает");
        }
         
        else {
            System.out.println("Количество стульев соответствует количеству учеников");
        }

        scanner.close();
    }
}