import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();

        int tens = (number / 10) * 10;
        int ones = number % 10;

        String output = tens + " + " + ones;
        System.out.println(output);
    }
}