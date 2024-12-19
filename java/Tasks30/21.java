import java.util.Scanner;

public class NearestRoundNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Введите положительное целое число: ");
        int number = scanner.nextInt();
        
        if (number > 0) {
            int nearestRoundNumber = (number / 10) * 10;

            if (number % 10 >= 5) {
                nearestRoundNumber += 10;
            }
        } 
        
        else {
            System.out.println("Число должно быть положительным.");
        }
        
        scanner.close();
    }
}