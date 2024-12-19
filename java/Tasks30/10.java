import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите целое положительное число: ");
        int inputNumber = scanner.nextInt();

        if (inputNumber >= 100) {
            inputNumber -= 1;
        }

        System.out.println("Результат: " + inputNumber);
    }
}