import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import java.math.BigDecimal;

@Entity
@DiscriminatorValue(value = "FiftyShades")
public class FiftyShadesShampoo extends BasicShampoo {

    private static final String BRAND = "Fifty Shades";

    private static final BigDecimal PRICE = new BigDecimal(6.69);

    public FiftyShadesShampoo() {
    }

    public FiftyShadesShampoo(BasicLabel label) {
        super(BRAND,PRICE,label);
    }
}
