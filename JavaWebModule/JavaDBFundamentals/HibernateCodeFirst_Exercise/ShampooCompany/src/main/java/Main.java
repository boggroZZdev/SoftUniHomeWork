import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import java.util.HashSet;

public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("shampoo_company");

        EntityManager em = emf.createEntityManager();

        em.getTransaction().begin();

        BasicIngredient am =  new AmmoniumChloride();
        BasicIngredient strwb = new StrawberryIngredient();
        BasicIngredient mint = new MintIngredient();
        BasicIngredient nettle = new NettleIngredient();
        BasicLabel label = new BasicLabel("Fresh Nuke", "Contains mint and nettle");
        BasicShampoo shampoo = new FreshNukeShampoo(label);

        HashSet ingredients = new HashSet();
        ingredients.add(mint);
        ingredients.add(nettle);
        ingredients.add(am);
        shampoo.setIngredients(ingredients);
        em.persist(shampoo);

        em.getTransaction().commit();
        em.close();
        emf.close();


    }
}
