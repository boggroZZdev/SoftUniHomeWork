import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import java.math.BigDecimal;

@Entity
@DiscriminatorValue(value = "NettleIngredient")
public class NettleIngredient extends BasicIngredient {
    @Override
    public void setId(int id) {

    }

    private static final String NAME = "NettleIngredient";

    private static final BigDecimal PRICE = new BigDecimal(6.12);

    public NettleIngredient() {
        super(NAME,PRICE);
    }
}
