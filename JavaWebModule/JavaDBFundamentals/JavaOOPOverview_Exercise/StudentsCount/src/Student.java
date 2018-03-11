public class Student {

    public String name;
    private static int STUDENT_COUNTER = 0;

    public static int getStudentCounter() {
        return STUDENT_COUNTER;
    }

    public static void createStudent(String name){
        Student student = new Student();
        student.name = name;
        STUDENT_COUNTER++;
    }
}
