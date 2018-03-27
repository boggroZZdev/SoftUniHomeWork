package EmployeesWithSalaryOver50000;

import entities.Employee;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");
        EntityManager em = emf.createEntityManager();

        Query sqlQuery = em.createQuery
                ("SELECT e FROM Employee AS e WHERE e.salary > 50000");

        List<Employee> employees = sqlQuery.getResultList();

        for (Employee e:employees) {
            System.out.println(e.getFirstName());
        }

        em.close();
        emf.close();
    }
}
