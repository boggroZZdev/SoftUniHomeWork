import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedHashSet;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String domain = "@gmail.com";

        LinkedHashSet<Student> students = new LinkedHashSet<>();

        while (true){
            String[] info = reader.readLine().split("\\s+");
            if (info[0].equals("END")){
                break;
            }else{
                String fName = info[0];
                String lName = info[1];
                String mail = info[2];
                Student student = new Student(fName,lName,mail);
                students.add(student);
            }
        }

        students.stream()
                .filter(x-> x.getEmail().endsWith(domain))
                .forEach(x-> System.out.println(x.toString()));
    }
}

class Student{
    public String firstName;
    public String lastName;
    public String email;


    @Override
    public String toString(){
        return this.getFirstName()+" "+this.getLastName();
    }
    public Student(String firstName, String lastName, String email) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
    }

    public Student() {

    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String getEmail() {
        return email;
    }
}
