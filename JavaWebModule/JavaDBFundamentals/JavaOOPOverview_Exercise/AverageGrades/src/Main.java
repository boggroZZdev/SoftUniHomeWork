import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;


public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int count = Integer.parseInt(reader.readLine());
        List<Student> allStudents = new ArrayList<>();

        for (int i = 0; i < count ; i++) {
            String[] argums = reader.readLine().split(" ");
            Student s = new Student();
            s.setName(argums[0]);
            ArrayList<Double> currentGrades = new ArrayList<>();
            for (int j = 1; j < argums.length ; j++) {
                currentGrades.add(Double.parseDouble(argums[j]));
            }
            s.setGrades(currentGrades);
            s.setAverageGrade();
            allStudents.add(s);
        }

        List<Student> highGraded = allStudents.stream().filter(b -> b.getAverageGrade()>=5.00)
                .collect(Collectors.toList());

        highGraded = highGraded.stream().sorted(
                Comparator.comparing(Student::getName)
                .thenComparing(Comparator.comparing(Student::getAverageGrade).reversed()))
                .collect(Collectors.toList());

        for (Student st: highGraded) {
            System.out.printf("%s -> %.2f\r\n",st.getName(),st.getAverageGrade());
        }
    }
}
