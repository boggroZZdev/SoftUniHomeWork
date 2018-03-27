package AddressesWithEmployeesCount;

import entities.Address;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("soft_uni");
        EntityManager em = emf.createEntityManager();

        Query query = em.createQuery("SELECT a FROM Address AS a ORDER BY a.employees.size DESC, a.town.id ASC");

        List<Address> addresses = query.setMaxResults(10).getResultList();


        addresses.stream().forEach(x -> System.out.printf(x.getText()+", "+x.getTown().getName()+" - "+x.getEmployees().size()+" employees\r\n"));


        em.close();
        emf.close();
    }
}
