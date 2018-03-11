import java.util.ArrayList;
import java.util.List;

public class Student {
    public String name;
    public List<Double> grades;
    private double averageGrade;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public List<Double> getGrades() {
        return grades;
    }

    public void setGrades(ArrayList<Double> grades) {
        this.grades = grades;
    }

    public double getAverageGrade() {
        return averageGrade;
    }

    public void setAverageGrade() {
        this.averageGrade = grades.stream().mapToDouble(a->a).average().getAsDouble();
    }


}
