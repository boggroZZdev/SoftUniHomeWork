import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import java.math.BigDecimal;

@Entity
@DiscriminatorValue(value = "Strawberry")
public class StrawberryIngredient extends BasicIngredient {

    private static final String NAME = "Strawberry";

    private static final BigDecimal PRICE = new BigDecimal(4.85);

    public StrawberryIngredient() {
        super(NAME,PRICE);
    }

    @Override
    public void setId(int id) {

    }
}
