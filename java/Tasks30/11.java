import java.util.Scanner;

public class NumberComparison {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите первое число: ");
        int firstNumber = Integer.parseInt(scanner.nextLine());

        System.out.print("Введите второе число: ");
        int secondNumber = Integer.parseInt(scanner.nextLine());

        if (firstNumber > secondNumber) {
            System.out.println("Сумма: " + (firstNumber + secondNumber));
        } 
        
        else if (firstNumber < secondNumber) {
            System.out.println("Произведение: " + (firstNumber * secondNumber));
        } 
        
        else {
            System.out.println("Числа равны");
        }
        scanner.close();
    }
}