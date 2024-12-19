import java.util.Scanner;

public class NumberComparison {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = new int[4];
        for (int i = 0; i < 4; i++) {
            System.out.printf("Введите число: ", i + 1);
            numbers[i] = Integer.parseInt(scanner.nextLine());
        }

        int maxNumber = numbers[0];
        int maxIndex = 0;
        boolean allEqual = true;

        for (int i = 1; i < 4; i++) {
            if (numbers[i] > maxNumber) {
                maxNumber = numbers[i];
                maxIndex = i;
            }
            if (numbers[i] != numbers[0]) {
                allEqual = false;
            }
        }

        if (allEqual) {
            System.out.println("Все числа равны");
        } 
        else {
            System.out.printf("Число больше всех", maxNumber);
            for (int i = 0; i < 3; i++) {
                for (int j = i + 1; j < 4; j++) {
                    if (numbers[i] == numbers[j]) {
                        System.out.printf("они все равны", numbers[i], numbers[j]);
                    }
                }
            }
        }

        scanner.close();
    }
}