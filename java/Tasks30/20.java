import java.util.Scanner;

public class CountZerosInNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите трехзначное положительное число: ");
        int number = scanner.nextInt();
        
        if (number >= 100 && number <= 999) {
            String numberStr = String.valueOf(number);
            int zeroCount = 0;
            
            for (int i = 0; i < numberStr.length(); i++) {
                if (numberStr.charAt(i) == '0') {
                    zeroCount++;
                }
            }
            System.out.println("Количество нулей в числе: " + zeroCount);
        } 
        
        else {
            System.out.println("Число должно быть трехзначным.");
        }
        
        scanner.close();
    }
}
