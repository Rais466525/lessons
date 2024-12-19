import java.util.Random;

public class RandomNumbers {
    public static void main(String[] args) {

        Random random = new Random();
        int firstNumber = 10 + random.nextInt(90);
        System.out.println("Первое случайное двузначное число: " + firstNumber);

        int secondNumber = random.nextInt(firstNumber);
        int thirdNumber = random.nextInt(firstNumber);
        int fourthNumber = random.nextInt(firstNumber);

        System.out.println("Второе случайное число: " + secondNumber);
        System.out.println("Третье случайное число: " + thirdNumber);
        System.out.println("Четвертое случайное число: " + fourthNumber);
    }
}
