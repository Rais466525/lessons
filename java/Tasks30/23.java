import java.util.Scanner;

public class MonthSeason {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите порядковый номер месяца: ");
        int monthNumber = scanner.nextInt();

        if (monthNumber >= 1 && monthNumber <= 12) {
            String season;
            if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2) {
                season = "Зима";
            } else if (monthNumber >= 3 && monthNumber <= 5) {
                season = "Весна";
            } else if (monthNumber >= 6 && monthNumber <= 8) {
                season = "Лето";
            } else {
                season = "Осень";
            }

            System.out.println("Месяц " + monthNumber + " относится к сезону: " + season);
        } 
        
        else {
            System.out.println("Неверный номер месяца. Введите число от 1 до 12.");
        }

        scanner.close();
    }
}
