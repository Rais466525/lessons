import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Введите целое число: ");
        int inputNumber = scanner.nextInt();

        if (inputNumber > 0) {
            inputNumber *= 2;
        }
        
        System.out.println("Новое значение: " + inputNumber);
        scanner.close();
    }
}