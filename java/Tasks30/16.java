import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите число: ");
        int inputNumber = scanner.nextInt();

        if (inputNumber < 0) {
            System.out.println("Квадрат числа: " + (inputNumber * inputNumber));
        } 
        else {
            System.out.println("Ошибка");
        }
        
        scanner.close();
    }
}