import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

public class Main {
    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        LinkedHashSet<Student> students = new LinkedHashSet<>();
        while(true){
            String[] info = reader.readLine().split("\\s+");
            if (info[0].equals("END")){
                break;
            }else{

                String fNumber = info[0];
                Integer[] gradeArr = Arrays.stream(info).skip(1).map(Integer::parseInt).toArray(Integer[]::new);
                Student student = new Student(fNumber,gradeArr);
                students.add(student);
            }
        }

        students.stream()
                .filter(g-> g.getFacultyNumber().endsWith("14")|| g.getFacultyNumber().endsWith("15"))
                .map(Student::getGrades)
                .map(c-> Arrays.stream(c).map(String::valueOf).toArray(String[]::new))
                .forEach(x-> System.out.println(String.join(" ", x)));

    }
}

class Student {
    private String facultyNumber;
    private Integer[] grades;

    public Student() {
    }

    public Student(String facultyNumber, Integer[] grades) {
        this.facultyNumber = facultyNumber;
        this.grades = grades;
    }

    public String getFacultyNumber() {
        return facultyNumber;
    }

    public Integer[] getGrades() {
        return grades;
    }
}
