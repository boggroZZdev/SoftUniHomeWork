import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import java.math.BigDecimal;

@Entity
@DiscriminatorValue(value = "Lavender")
public class LavenderIngredient extends BasicIngredient {

    private static final String NAME = "Lavender";

    private static final BigDecimal PRICE = new BigDecimal(2);

    public LavenderIngredient() {
        super(NAME,PRICE);
    }

    @Override
    public void setId(int id) {

    }
}
