import java.util.Scanner;

class Person {
    String name;
    int age;
    char gender;
    boolean isWorking;

    public Person(String name, int age, char gender, boolean isWorking) {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.isWorking = isWorking;
    }

    @Override
    public String toString() {
        return "Person{" +
                "name='" + name + '\'' +
                ", age=" + age +
                ", gender=" + gender +
                ", isWorking=" + isWorking +
                '}';
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите имя: ");
        String name = scanner.nextLine();

        System.out.print("Введите возраст: ");
        int age = scanner.nextInt();
        scanner.nextLine();

        System.out.print("Введите пол (м/ж): ");
        char gender = scanner.nextLine().charAt(0);

        System.out.print("Работает ли человек (true/false): ");
        boolean isWorking = scanner.nextBoolean();

        Person person = new Person(name, age, gender, isWorking);

        System.out.println("Данные о человеке:");
        System.out.println(person);

        scanner.close();
    }
}