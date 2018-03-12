import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.LinkedHashSet;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        LinkedHashSet<Student> students = new LinkedHashSet<>();

        while(true){
            String[] info = reader.readLine().split("\\s+");

            if (info[0].equals("END")){
                break;
            }else{
                String fName = info[0];
                String lName = info[1];
                Student student = new Student(fName,lName);
                students.add(student);
            }
        }
        students.stream().filter(x-> x.getFirstName().compareTo(x.getLastName()) <= 0)
        .forEach(x-> System.out.println(x.getFirstName()+" "+x.getLastName()));
    }
}
class Student{
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
}
