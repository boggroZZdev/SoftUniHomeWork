import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedHashSet;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        LinkedHashSet<Student> students = new LinkedHashSet<>();

        while (true){
            String[] info = reader.readLine().split("\\s+");
            if (info[0].equals("END")){
                break;
            }else{
                String fName = info[0];
                String lName = info[1];
                int age = Integer.parseInt(info[2]);

                Student student = new Student(fName,lName,age);
                students.add(student);
            }
        }

        students.stream()
                .filter(x-> x.getAge()>= 18 && x.getAge()<= 24)
                .forEach(x-> System.out.println(x.toString()));
    }
}

class Student {
    private String firstName;
    private String secondName;
    private int age;

    public Student(String firstName, String secondName, int age) {
        this.firstName = firstName;
        this.secondName = secondName;
        this.age = age;
    }

    public Student() {
    }

    public String getFirstName() {
        return firstName;
    }

    public String getSecondName() {
        return secondName;
    }

    public int getAge() {
        return age;
    }

    @Override
    public String toString() {
        return this.getFirstName()+" "+this.getSecondName()+" "+this.getAge();
    }
}
