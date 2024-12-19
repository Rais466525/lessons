import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Input: ");
        int enter = scanner.nextInt();

        int a = enter / 100;
        int b = (enter / 10) % 10;
        int c = enter % 10;

        System.out.println("Output: " + c + " " + b + " " + a);
    }
}