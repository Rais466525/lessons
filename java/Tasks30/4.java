import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите целое трехзначное число: ");
        int number = scanner.nextInt();

        if (number >= 100 && number <= 999) {
            int hundreds = (number / 100) * 100;
            int tens = ((number / 10) % 10) * 10;
            int ones = number % 10;
            String result = hundreds + " + " + tens + " + " + ones;

            System.out.println("Результат: " + result);
        } else {
            System.out.println("Ошибка: введите трехзначное число!");
        }
        scanner.close();
    }
}

