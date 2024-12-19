import java.util.Scanner;

public class UniqueDigits {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите положительное трехзначное число: ");
        int number = scanner.nextInt();

        if (number >= 100 && number <= 999) {

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            if (firstDigit == secondDigit && secondDigit == thirdDigit) {
                System.out.println("Все цифры одинаковы.");
            } 
            else if (firstDigit == secondDigit || firstDigit == thirdDigit || secondDigit == thirdDigit) {
                System.out.println("Две цифры одинаковы.");
            } 
            else {
                System.out.println("Все цифры разные.");
            }
        } 

        else {
            System.out.println("Число должно быть положительным трехзначным.");
        }

        scanner.close();
    }
}
