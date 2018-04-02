import entities.BankAccount;
import entities.CreditCard;
import entities.User;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("billing");

        EntityManager em = emf.createEntityManager();

        em.getTransaction().begin();

        em.getTransaction().commit();


        em.close();
        emf.close();
    }
}
