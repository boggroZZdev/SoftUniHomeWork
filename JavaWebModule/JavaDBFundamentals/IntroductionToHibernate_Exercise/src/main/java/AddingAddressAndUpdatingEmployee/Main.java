package AddingAddressAndUpdatingEmployee;

import entities.Address;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");
        EntityManager em = emf.createEntityManager();

        Address vitoshka15 = new Address();
        vitoshka15.setText("Vitoshka 15");

        em.getTransaction().begin();

        em.persist(vitoshka15);

        em.getTransaction().commit();

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String name = reader.readLine();

        em.getTransaction().begin();

        Query query = em.createQuery("UPDATE Employee AS e SET e.address = :address WHERE e.lastName = :name");
        query.setParameter("address", vitoshka15);
        query.setParameter("name", name);
        query.executeUpdate();

        em.getTransaction().commit();
        em.close();
        emf.close();
    }
}
