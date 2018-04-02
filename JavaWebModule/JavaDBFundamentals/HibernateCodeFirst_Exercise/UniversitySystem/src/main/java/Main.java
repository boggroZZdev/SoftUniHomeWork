import entities.Course;
import entities.Person;
import entities.Student;
import entities.Teacher;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import java.util.HashSet;
import java.util.Set;

public class Main {
    public static void main(String[] args) {

        EntityManagerFactory emf = Persistence.createEntityManagerFactory("university");

        EntityManager em = emf.createEntityManager();

        em.getTransaction().begin();


        em.getTransaction().commit();

        em.close();
        emf.close();
    }
}
