import java.util.Scanner;

public class DoubleEvenNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Введите трехзначное число: ");
        int number = scanner.nextInt();
        
        if (number >= 100 && number <= 999) {

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int ones = number % 10;
            
            if (number % 2 == 0 && (hundreds + tens + ones) % 2 == 0) {
                System.out.println("Число является дважды четным.");
            } 
            else {
                System.out.println("Число не является дважды четным.");
            }
        } 
        
        else {
            System.out.println("Число должно быть трехзначным.");
        }
        
        scanner.close();
    }
}
