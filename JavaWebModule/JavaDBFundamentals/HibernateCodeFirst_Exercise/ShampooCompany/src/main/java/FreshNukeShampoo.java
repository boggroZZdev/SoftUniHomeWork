import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import java.math.BigDecimal;

@Entity
@DiscriminatorValue(value = "FreshNuke")
public class FreshNukeShampoo extends BasicShampoo {

    private static final String BRAND = "Fresh Nuke";

    private static final BigDecimal PRICE = new BigDecimal(9.33);

    public FreshNukeShampoo() {
    }

    public FreshNukeShampoo(BasicLabel label) {
        super(BRAND, PRICE, label);
    }
}
