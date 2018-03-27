package ContainsEmployees;

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
        String fullName = reader.readLine();

        Query getNames = em.createQuery(
                "SELECT CONCAT(e.firstName,' ',e.lastName) AS full_name FROM Employee AS e WHERE CONCAT(e.firstName,' ',e.lastName) = :name"
        );

        getNames.setParameter("name",fullName);

        List<Employee> employees = getNames.getResultList();

        if (employees.isEmpty()){
            System.out.println("No");
        }else{
            System.out.println("Yes");
        }

        em.close();
        emf.close();
    }
}
