import java.util.Scanner;

public class NumberCheck {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите целое число: ");
        int inputNumber = scanner.nextInt();

        if (inputNumber > 0) {
            System.out.println("Положительное");
        } else if (inputNumber < 0) {
            System.out.println("Отрицательное");
        } else {
            System.out.println("Ноль");
        }
        
        scanner.close();
    }
}