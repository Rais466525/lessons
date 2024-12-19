import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите целое двузначное число: ");
        int number = scanner.nextInt();

        if (10 <= number && number <= 99) {
            int reversed_number = (number % 10) * 10 + (number / 10);
            int result = reversed_number + 8;
            System.out.println("Результат: " + result);
        } else {
            System.out.println("Ошибка: введите двузначное число!");
        }
        scanner.close();
    }
}

