import java.util.Scanner;

public class CheckLatinLetter {
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите символ: ");
        char inputChar = scanner.next().charAt(0);

        if ((inputChar >= 'a' && inputChar <= 'z') || (inputChar >= 'A' && inputChar <= 'Z')) {
            System.out.println("Символ является буквой латинского алфавита.");
        } 
        else {
            System.out.println("Символ не является буквой латинского алфавита.");
        }

        scanner.close();
    }
}
