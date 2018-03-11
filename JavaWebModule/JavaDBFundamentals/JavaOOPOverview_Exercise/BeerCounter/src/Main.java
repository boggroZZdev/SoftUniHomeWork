import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        try {
            while (true) {
                String arg = reader.readLine();

                if (!arg.equals("End")) {
                    String[] nums = arg.split("\\s+");
                    BeerCounter.buyBeer(Integer.parseInt(nums[0]));
                    BeerCounter.drinkBeer(Integer.parseInt(nums[1]));
                } else {
                    break;
                }
            }
        } catch (Exception _ignored) {

        } finally {
            BeerCounter.printResult();
        }
    }
}
