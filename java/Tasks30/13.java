import java.util.Scanner;

public class TwoDigitNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите 2-значное число: ");
        int number = scanner.nextInt();

        int firstDigit = number / 10;
        int secondDigit = number % 10;
        int product = firstDigit * secondDigit;

        if (product > number) {
            System.out.println(product + ">" + number);
        } 
        
        else {
            System.out.println(number + ">" + product);
        }
    }
}