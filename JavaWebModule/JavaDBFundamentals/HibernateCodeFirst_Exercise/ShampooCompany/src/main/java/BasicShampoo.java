import javax.persistence.*;
import java.math.BigDecimal;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name = "shampoos")
@Inheritance(strategy = InheritanceType.SINGLE_TABLE)
@DiscriminatorColumn(name = "shampoo_type", discriminatorType = DiscriminatorType.STRING)
public class BasicShampoo implements Shampoo {
    @Id
    private long id;

    @Basic
    private BigDecimal price;

    @Basic
    private String brand;




    public BasicShampoo() {
        this.setIngredients(new HashSet<>());
    }

    @OneToOne(optional = true, cascade = CascadeType.ALL, fetch = FetchType.LAZY)
    @JoinColumn(name = "label", referencedColumnName = "id")
    private BasicLabel label;

    @ManyToMany(cascade = CascadeType.ALL, fetch = FetchType.LAZY)
    @JoinTable(name = "shampoo_ingredients", joinColumns = @JoinColumn(name = "shampoo_id", referencedColumnName = "id")
            , inverseJoinColumns = @JoinColumn(name = "ingredient_id", referencedColumnName = "id"))
    private Set<BasicIngredient> ingredients;


    public BasicShampoo(String brand, BigDecimal price,  BasicLabel label) {
        this.price = price;
        this.brand = brand;
        this.label = label;
    }

    @Override
    public long getId() {
        return id;
    }

    @Override
    public void setId(long id) {

    }

    @Override
    public String getBrand() {
        return null;
    }

    @Override
    public void setBrand(String brand) {

    }

    @Override
    public BigDecimal getPrice() {
        return null;
    }

    @Override
    public void setPrice(BigDecimal price) {

    }



    @Override
    public BasicLabel getLabel() {
        return null;
    }

    @Override
    public void setLabel(BasicLabel label) {

    }

    @Override
    public Set<BasicIngredient> getIngredients() {
        return this.ingredients;
    }

    @Override
    public void setIngredients(Set<BasicIngredient> ingredients) {

    }
}
