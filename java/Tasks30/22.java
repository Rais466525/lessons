import java.util.Scanner;

public class LuckyTicket {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите шестизначный номер билета: ");
        int ticketNumber = scanner.nextInt();

        if (ticketNumber >= 100000 && ticketNumber <= 999999) {
            int firstSum = (ticketNumber / 100000) + (ticketNumber / 10000 % 10) + (ticketNumber / 1000 % 10);
            int secondSum = (ticketNumber / 100 % 10) + (ticketNumber / 10 % 10) + (ticketNumber % 10);

            if (firstSum == secondSum && firstSum % 2 == 0) {
                System.out.println("Билет счастливый.");
            } 
            else {
                System.out.println("Билет не счастливый.");
            }

        } 
        else {
            System.out.println("Номер билета должен быть шестизначным.");
        }
        
        scanner.close();
    }
}