package IncreaseSalaries;

import entities.Employee;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.math.BigDecimal;
import java.util.List;

import static javafx.scene.input.KeyCode.L;

public class Main {
    public static void main(String[] args) {

        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");

        EntityManager em = emf.createEntityManager();

        em.getTransaction().begin();

        List<Employee> employees = em.createQuery("SELECT e FROM Employee AS e WHERE e.department.id IN (1,2,4,11)" +
                "ORDER BY e.id").getResultList();

        Query query = em.createQuery("UPDATE Employee AS e SET e.salary = e.salary*1.12 WHERE e.department.id IN (1,2,4,11)");

        query.executeUpdate();

        String debug = "";

        em.getTransaction().commit();

        employees.stream().forEach(x-> System.out.printf("%s %s ($%.2f)\r\n",x.getFirstName(),x.getLastName(),x.getSalary()));
        em.close();
        emf.close();

    }
}
