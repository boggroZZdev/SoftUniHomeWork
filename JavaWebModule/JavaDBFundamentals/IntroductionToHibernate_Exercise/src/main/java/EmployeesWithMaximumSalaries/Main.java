package EmployeesWithMaximumSalaries;

import entities.Department;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.math.BigDecimal;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");
        EntityManager em = emf.createEntityManager();


        Query query = em.createQuery(
                "SELECT d.name, MAX(e.salary) FROM Department AS d INNER JOIN Employee AS e ON e.department.id = d.id GROUP BY d.name HAVING MAX(e.salary) NOT BETWEEN 30000 AND 70000 ORDER BY MAX(e.salary) ASC"
        );

        List<Object[]> departments = query.getResultList();

        departments.stream().forEach(x->
                System.out.println(String.format("%s - %.2f",x[0],x[1])));



        em.close();
        emf.close();
        String debug = "";
    }
}
