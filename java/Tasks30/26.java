import java.util.Scanner;

public class CheckNames {
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите первое имя: ");
        String name1 = scanner.nextLine();

        System.out.print("Введите второе имя: ");
        String name2 = scanner.nextLine();

        if (name1.equals(name2)) {
            System.out.println("Это тезки!");
        } 
        else {
            System.out.println("Это не тезки.");
        }

        scanner.close();
    }
}
