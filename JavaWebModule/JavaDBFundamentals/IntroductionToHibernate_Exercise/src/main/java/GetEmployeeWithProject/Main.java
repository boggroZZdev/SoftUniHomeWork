package GetEmployeeWithProject;

import entities.Employee;
import entities.Project;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Set;

public class Main {
    public static void main(String[] args) throws IOException {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");
        EntityManager em = emf.createEntityManager();

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int id = Integer.parseInt(reader.readLine());


        List<Employee> employees = em.createQuery("SELECT e FROM Employee AS e WHERE e.id = :id").setParameter("id", id).getResultList();

        Employee emp = employees.get(0);

        System.out.printf("%s %s - %s\r\n",emp.getFirstName(),emp.getLastName(),emp.getJobTitle());
        emp.getProjects().stream().sorted(Comparator.comparing(Project::getName)).forEach(x-> System.out.println("   "+x.getName()));

        em.close();
        emf.close();
    }
}
