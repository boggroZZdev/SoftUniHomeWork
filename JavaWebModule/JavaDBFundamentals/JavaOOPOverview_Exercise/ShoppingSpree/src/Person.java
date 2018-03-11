import java.util.List;

public class Person {

    public String name;
    public double money;
    public List<Product> bagOfProducts;

    public String getName() {
        return name;
    }

    public void setName(String name) {

        this.name = name;

    }

    public double getMoney() {
        return money;
    }

    public void setMoney(double money) {

        this.money = money;

    }

    public List<Product> getBagOfProducts() {
        return bagOfProducts;
    }

    public void setBagOfProducts(List<Product> bagOfProducts) {
        this.bagOfProducts = bagOfProducts;
    }

    public void addToBagOfProducts(Product product) {
        this.bagOfProducts.add(product);
    }

    public String stringifyBag(List<Product> bag) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < bag.size(); i++) {
           if (i!=bag.size()-1){
               Product product = bag.get(i);
               sb.append(product.getName()+", ");
           }else{
               Product product = bag.get(i);
               sb.append(product.getName());
           }
        }
    return sb.toString();
    }
}
