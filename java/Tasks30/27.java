import java.util.Random;

public class RandomTwoDigitNumber {
    public static void main(String[] args) {

        Random random = new Random();
        int randomNumber = 10 + random.nextInt(90);
        
        System.out.println("Случайное двузначное число: " + randomNumber);
    }
}
