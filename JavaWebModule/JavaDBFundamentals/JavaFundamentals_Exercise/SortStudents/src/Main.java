import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));


        List<Student> students = new ArrayList<>();
        while (true) {
            String[] info = reader.readLine().split("\\s+");
            if (info[0].equals("END")) {
                break;
            } else {
                String fName = info[0];
                String lName = info[1];

                Student student = new Student(fName, lName);
                students.add(student);
            }
        }

        students.stream()
                .sorted(Comparator.comparing(Student::getLastName)
                        .thenComparing(Comparator.comparing(Student::getFirstName).reversed()))
                .forEach(x-> System.out.println(x.toString()));
    }
}

class Student {
    private String firstName;
    private String lastName;

    public Student(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Student() {
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    @Override
    public String toString() {
        return this.getFirstName() + " " + this.getLastName();
    }
}
