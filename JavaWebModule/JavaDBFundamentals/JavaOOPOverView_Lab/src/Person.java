import java.util.List;

public class Person {

    private String name;
    private int age;
    private List<BankAccount> accounts;

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public Person(String name, int age, List<BankAccount> accounts) {
        this.name = name;
        this.age = age;
        this.accounts = accounts;
    }

    public double getBalance() {

        double result = 0f;

        for (BankAccount acc : accounts) {
            result += acc.getBalance();
        }

        return result;
    }
}