package RemoveObjects;

import entities.Town;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");

        EntityManager em = emf.createEntityManager();

        Query getAll = em.createQuery("SELECT t FROM Town AS t");

        List<Town> allTowns = getAll.getResultList();

        em.getTransaction().begin();

        for (Town t:allTowns) {
            if (t.getName().length()<=5){
                t.setName(t.getName().toLowerCase());
            }
        }

        em.getTransaction().commit();

        em.close();
        emf.close();
        String debug = "";
    }
}
