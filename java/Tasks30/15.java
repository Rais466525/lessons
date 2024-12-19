import java.util.Scanner;

public class NumberSorting {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите первое число: ");

        int firstNumber = Integer.parseInt(scanner.nextLine());
        System.out.print("Введите второе число: ");
        
        int secondNumber = Integer.parseInt(scanner.nextLine());
        System.out.print("Введите третье число: ");
        int thirdNumber = Integer.parseInt(scanner.nextLine());

        if (firstNumber <= secondNumber && firstNumber <= thirdNumber) {

            if (secondNumber <= thirdNumber) {
                System.out.println(firstNumber + " " + secondNumber + " " + thirdNumber);
            } 
            else {
                System.out.println(firstNumber + " " + thirdNumber + " " + secondNumber);
            }
        } 
        
        
        else if (secondNumber <= firstNumber && secondNumber <= thirdNumber) {

            if (firstNumber <= thirdNumber) {
                System.out.println(secondNumber + " " + firstNumber + " " + thirdNumber);
            } 
            else {
                System.out.println(secondNumber + " " + thirdNumber + " " + firstNumber);
            }
        } 
        
        else {
            if (firstNumber <= secondNumber) {
                System.out.println(thirdNumber + " " + firstNumber + " " + secondNumber);
            } else {
                System.out.println(thirdNumber + " " + secondNumber + " " + firstNumber);
            }
        }

        scanner.close();
    }
}