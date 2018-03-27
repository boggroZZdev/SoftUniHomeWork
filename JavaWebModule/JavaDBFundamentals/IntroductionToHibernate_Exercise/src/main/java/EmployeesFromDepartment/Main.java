package EmployeesFromDepartment;

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

        Query query = em.createQuery("SELECT e FROM Employee AS e WHERE e.department.name='Research and Development' ORDER BY e.salary ASC, e.id ASC ");

        List<Employee> employees = query.getResultList();

        employees.stream().forEach(x-> System.out.println(x.getFirstName()+" "+x.getLastName()+" from "
                +x.getDepartment().getName()+" - $"+String.format("%.2f", x.getSalary())));

        em.close();
        emf.close();
    }
}
