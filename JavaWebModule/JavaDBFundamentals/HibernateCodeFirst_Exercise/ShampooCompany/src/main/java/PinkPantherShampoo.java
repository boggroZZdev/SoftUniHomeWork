import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import java.math.BigDecimal;

@Entity
@DiscriminatorValue(value = "PinkPanther")
public class PinkPantherShampoo extends BasicShampoo {

    private static final String BRAND = "Pink Panter";

    private static final BigDecimal PRICE = new BigDecimal(9.33);

    public PinkPantherShampoo() {
    }

    public PinkPantherShampoo(BasicLabel label) {
        super(BRAND,PRICE, label);
    }
}
