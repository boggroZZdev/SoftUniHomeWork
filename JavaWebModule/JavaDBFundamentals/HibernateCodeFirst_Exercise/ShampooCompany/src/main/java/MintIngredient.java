import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import java.math.BigDecimal;

@Entity
@DiscriminatorValue(value = "Mint")
public class MintIngredient extends BasicIngredient {
    @Override
    public void setId(int id) {

    }

    private static final String NAME = "Mint";

    private static final BigDecimal PRICE = new BigDecimal(3.54);

    public MintIngredient() {
        super(NAME,PRICE);
    }
}
