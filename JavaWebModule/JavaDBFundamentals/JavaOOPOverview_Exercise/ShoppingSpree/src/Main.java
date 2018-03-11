import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

public class Main {
    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));


        //region Setting Up


        String[] personNames = reader.readLine().split("[;= ]");

        LinkedHashSet<Person> persons = new LinkedHashSet<>();
        ArrayList<Product> products = new ArrayList<>();

        for (int i = 0; i < personNames.length; i += 2) {

            String personName = personNames[i];
            int personMoney = Integer.parseInt(personNames[i + 1]);
            Person person = new Person();
            person.setName(personName);
            person.setMoney(personMoney);
            person.setBagOfProducts(new ArrayList<>());
            persons.add(person);
        }

        String[] productNames = reader.readLine().split("[;= ]");

        for (int i = 0; i < productNames.length; i += 2) {

            String productName = productNames[i];
            int productCost = Integer.parseInt(productNames[i + 1]);
            Product product = new Product();
            product.setName(productName);
            product.setCost(productCost);
            products.add(product);
        }
        //endregion


        while (true) {
            String command = reader.readLine().trim();
            if (command.equals("END")) {
                break;
            } else if (command.equals("") || command.equals(" ") || command.length() < 3) {

            } else {
                if (command.contains(" ")) {
                    String[] arguments = command.split(" ");
                    String buyerName = arguments[0];
                    String productName = arguments[1];

                    for (Person p : persons) {
                        if (p.getName().equals(buyerName)) {
                            if (buyerName.equals("")) {
                                System.out.println("Name cannot be empty");
                                return;
                            } else if (p.getMoney() < 0) {
                                System.out.println("Money cannot be negative");
                                return;
                            } else {
                                for (Product pr : products) {
                                    if (pr.getName().equals("") & pr.getName().equals(productName)) {
                                        System.out.println("Name cannot be empty");
                                        break;
                                    } else if (pr.getCost() < 0 && pr.getName().equals(productName)) {
                                        System.out.println("Cost cannot be negative");
                                        break;
                                    } else if (pr.getCost() > p.getMoney() && pr.getName().equals(productName)) {
                                        System.out.printf("%s can't afford %s\r\n", p.getName(), pr.getName());
                                        break;
                                    } else if (pr.getName().equals(productName) && pr.getCost() <= p.getMoney()) {
                                        p.setMoney(p.getMoney() - pr.getCost());
                                        p.addToBagOfProducts(pr);
                                        System.out.printf("%s bought %s\r\n", p.getName(), pr.getName());
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }else{

                }
            }

        }
        for (Person buyer : persons) {
            if (buyer.bagOfProducts.isEmpty()) {
                System.out.printf("%s - Nothing bought\r\n", buyer.getName());
            }else if(buyer.money<0){
f
            }
            else{
                String buys = buyer.stringifyBag(buyer.bagOfProducts);
                System.out.printf("%s - %s\r\n", buyer.getName(), buys);
            }
        }
    }
}