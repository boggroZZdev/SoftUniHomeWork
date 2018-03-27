package FindEmployeesByFirstName;

import entities.Employee;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");
        EntityManager em = emf.createEntityManager();

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = reader.readLine();

        Query query = em.createQuery("SELECT e FROM Employee AS e WHERE e.firstName LIKE :pattern")
                .setParameter("pattern",input+"%");

        List<Employee> employees = query.getResultList();


        employees.stream().forEach(x-> System.out.printf("%s %s - %s - ($%.2f)\r\n",x.getFirstName(),x.getLastName(),x.getJobTitle(),x.getSalary()));

        em.close();
        emf.close();
    }
}
