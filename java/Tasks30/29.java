import java.util.Random;
import java.util.Scanner;

public class GuessNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        Random random = new Random();

        System.out.print("Введите нижний диапазон: ");
        int lowerBound = scanner.nextInt();

        System.out.print("Введите верхний диапазон: ");
        int upperBound = scanner.nextInt();

        int randomNumber = lowerBound + random.nextInt(upperBound - lowerBound + 1);
        System.out.print("Введите ваше число: ");
        int userNumber = scanner.nextInt();

        if (userNumber == randomNumber) {
            System.out.println("Окуучу тапты!");
        } 
        else {
            System.out.println("Окуучу таппады!");
        }
        scanner.close();
    }
}
