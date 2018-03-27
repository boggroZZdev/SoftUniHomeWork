package RemoveTowns;

import entities.Address;
import entities.Employee;
import entities.Town;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");
        EntityManager em = emf.createEntityManager();


        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String town = reader.readLine();

        em.getTransaction().begin();
        int size = em.createQuery("SELECT a FROM Address AS a WHERE a.town.name =:name").setParameter("name", town).getResultList().size();
        try {


            List<Address> addresses = em.createQuery("SELECT a FROM Address AS a WHERE a.town.name =:name").setParameter("name", town).getResultList();
            Town result = (Town)em.createQuery("SELECT t FROM Town AS t WHERE t.name =:name").setParameter("name", town).getSingleResult();

            for (Address a:addresses) {
                for (Employee e:a.getEmployees()) {
                    e.setAddress(null);
                }
                em.remove(a);
            }
            em.remove(result);
            em.getTransaction().commit();
        } catch (Exception e) {
            em.getTransaction().rollback();
        } finally {
            switch (size) {
                case 1:
                    System.out.printf("1 address in %s deleted\r\n", town);
                    break;
                default:
                    System.out.printf("%d addresses in %s deleted\r\n",size,town);
                    break;
            }
        }

        em.close();
        emf.close();
    }
}
