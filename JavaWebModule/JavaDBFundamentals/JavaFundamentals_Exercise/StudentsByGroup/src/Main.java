import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Student> students = new ArrayList<>();

        while(true){
            String[] info = reader.readLine().split("\\s+");
            if (info[0].equals("END")){
                break;
            }else {
                String fName = info[0];
                String lName = info[1];
                int group = Integer.parseInt(info[2]);

                Student student = new Student(fName, lName, group);
                students.add(student);
            }
        }

        students.stream()
                .filter(x-> x.getGroup() == 2)
                .sorted(Comparator.comparing(Student::getFirstName))
                .forEach(x-> System.out.println(x.getFirstName()+" "+x.getLastName()));
    }
}

class Student{
    private String firstName;
    private String lastName;
    private int group;

    public Student() {

    }

    public Student(String firstName, String lastName, int group) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.group = group;
    }

    public int getGroup() {
        return group;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }
}
