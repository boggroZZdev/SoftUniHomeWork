import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
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
                int[] gradeArr = Arrays.stream(info).skip(2).mapToInt(Integer::parseInt).toArray();

                Student student = new Student(fName, lName, gradeArr);

                students.add(student);
            }
        }

        students.stream()
                .filter(x -> Arrays.stream(x.getGrades())
                        .anyMatch(g -> g == 6))
                .forEach(x -> System.out.println(x.toString()));
    }
}

class Student {
    private String firstName;
    private String lastName;
    private int[] grades;


    @Override
    public String toString() {
        return this.getFirstName() + " " + this.getLastName();
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public int[] getGrades() {
        return grades;
    }

    public Student(String firstName, String lastName, int[] grades) {

        this.firstName = firstName;
        this.lastName = lastName;
        this.grades = grades;
    }

    public Student() {

    }
}
