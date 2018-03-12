import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Optional;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Optional<Integer> sum = Arrays.stream(
                reader.readLine().split("\\s+"))
                .filter(x-> isNumber(x))
                .map(Integer::parseInt)
                .reduce((x1,x2) -> x1+x2);

        if  (sum.isPresent()){
            System.out.println(sum.get().intValue());
        }else {
            System.out.println("No match");
        }
    }
    public static boolean isNumber(String x){
        try {
            int b = Integer.parseInt(x);
        }catch (Exception e){
            return false;
        }
        return true;
    }
}
