import java.util.Scanner;

public class ThreeDigitNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите целое положительное трехзначное число: ");
        int number = scanner.nextInt();

        if (number >= 100 && number <= 999) {

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            int total = firstDigit + secondDigit + thirdDigit;
            String result = firstDigit + " + " + secondDigit + " + " + thirdDigit + " = " + total;

            System.out.println("Результат: " + result);
        } 
        
        else {
            System.out.println("Ошибка: введите трехзначное число!");
        }
        
        scanner.close();
    }
}