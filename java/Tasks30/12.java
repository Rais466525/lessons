import java.util.Scanner;

class NumberChecker {
    private int number;

    public NumberChecker(int number) {
        this.number = number;
    }
    
    public void check() {
        int firstDigit = this.number / 100;
        int secondDigit = (this.number / 10) % 10;
        int thirdDigit = this.number % 10;

        if (firstDigit % 2 == 0 && secondDigit % 2 == 0 && thirdDigit % 2 == 0) {
            System.out.println("Четнокрасивое");
        } 
        
        else {
            System.out.println("Не четнокрасивое");
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите трехзначное число: ");
        int number = scanner.nextInt();

        NumberChecker checker = new NumberChecker(number);
        checker.check();
        scanner.close();
    }
}