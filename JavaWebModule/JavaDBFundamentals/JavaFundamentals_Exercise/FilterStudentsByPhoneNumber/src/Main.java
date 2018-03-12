import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Student> students = new ArrayList<>();
        while (true){
            String[] info = reader.readLine().split("\\s+");
            if (info[0].equals("END")){
                break;
            }else{
                String fName = info[0];
                String lName = info[1];
                String phone = info[2];

                Student student = new Student(fName,lName,phone);

                students.add(student);
            }
        }

        students.stream()
                .filter(x -> x.getPhonenumber().startsWith("02") || x.getPhonenumber().startsWith("+3592"))
                .forEach(x-> System.out.println(x.toString()));
    }
}

class Student{
    private String firstName;
    private String lastName;
    private String phonenumber;

    @Override
    public String toString() {
        return this.getFirstName()+" "+this.getLastName();
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String getPhonenumber() {
        return phonenumber;
    }

    public Student(String firstName, String lastName, String phonenumber) {

        this.firstName = firstName;
        this.lastName = lastName;
        this.phonenumber = phonenumber;
    }

    public Student() {

    }
}
