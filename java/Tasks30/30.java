import java.util.Random;
import java.util.Scanner;

public class RockPaperScissors {
    public static void main(String[] args) throws InterruptedException {

        String[] actions = {"Камень", "Ножницы", "Бумага"};
        Random random = new Random();
        int ai = random.nextInt(3);

        System.out.println("Виды действий:");
        System.out.println("1) Камень");
        System.out.println("2) Ножницы");
        System.out.println("3) Бумага");
        Thread.sleep(500);

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите действие: ");
        int player = scanner.nextInt() - 1;

        if (player < 0 || player >= 3) {
            System.out.println("Неверное действие.");
        } else {
            System.out.println("Вы выбрали: " + actions[player]);
            Thread.sleep(600);
            System.out.println("А противник выбрал: " + actions[ai]);
            Thread.sleep(300);

            if (player == ai) {
                System.out.println("Ничья!");
            } else if ((player == 0 && ai == 1) || (player == 1 && ai == 2) || (player == 2 && ai == 0)) {
                System.out.println("Вы победили!");
            } else {
                System.out.println("Вы проиграли!");
            }
        }
        scanner.close();
    }
}