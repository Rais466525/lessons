import java.util.Scanner;
import java.util.Random;

public class RockPaperScissors {
    public static void main(String[] args) {

        String[] options = {"Камень", "Ножницы", "Бумага"};
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();

        System.out.print("Введите Камень, Ножницы или Бумага: ");
        String userChoice = scanner.nextLine();
        int computerChoice = random.nextInt(3);
        System.out.println("Протиник: " + options[computerChoice]);

        if (userChoice.equalsIgnoreCase(options[computerChoice])) {
            System.out.println("Ничья!");

        } else if ((userChoice.equalsIgnoreCase("Камень") && options[computerChoice].equals("Ножницы")) ||
                   (userChoice.equalsIgnoreCase("Ножницы") && options[computerChoice].equals("Бумага")) ||
                   (userChoice.equalsIgnoreCase("Бумага") && options[computerChoice].equals("Камень"))) {
            System.out.println("Победа");

        } else {
            System.out.println("Проигрыш");
        }

        scanner.close();
    }
}