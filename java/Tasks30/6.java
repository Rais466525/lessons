import java.util.Scanner;

public class ReverseThreeDigitNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите целое положительное трехзначное число: "); // Prompt for input
        int number = scanner.nextInt();

        if (100 <= number && number <= 999) {
            int reversedNumber = (number % 10) * 100 + ((number / 10) % 10) * 10 + (number / 100);
            int result = reversedNumber - 20;

            System.out.println("Результат: " + result);
        } else {
            System.out.println("Ошибка: введите трехзначное число!");
        }

        scanner.close();
    }
}