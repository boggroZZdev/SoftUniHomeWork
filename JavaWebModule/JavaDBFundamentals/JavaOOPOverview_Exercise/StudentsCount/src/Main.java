import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        while (true){
            String command = reader.readLine();
            if (!command.equals("End")){
                Student.createStudent(command);
            }else{
                break;
            }
        }
        System.out.println(Student.getStudentCounter());
    }
}
