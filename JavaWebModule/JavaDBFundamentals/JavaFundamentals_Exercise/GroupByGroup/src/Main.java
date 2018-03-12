import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));


        List<Person> personList = new ArrayList<>();

        while (true) {
            String[] info = reader.readLine().split("\\s+");

            if (!info[0].equals("END")) {
                try {
                    String fName = info[0];
                    String lName = info[1];
                    int grp = Integer.parseInt(info[2]);

                    Person person = new Person(fName, lName, grp);
                    personList.add(person);
                } catch (Exception e) {

                }
            } else {
                break;
            }
        }

        personList.stream().collect(Collectors.groupingBy(Person::getGroup))
                .forEach((key, value) -> {
                    String names = value.stream().map(Person::getName).collect(Collectors.joining(", "));
                    String format = String.format("%d - %s", key, names);
                    System.out.println(format);
                });
    }
}

class Person {
    private String firstName;
    private String lastName;
    private int group;


    public String getName() {
        return this.firstName + " " + this.lastName;
    }

    public Person() {
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public int getGroup() {
        return group;
    }

    public Person(String firstName, String lastName, int group) {
        this.firstName = firstName;

        this.lastName = lastName;
        this.group = group;
    }

}
