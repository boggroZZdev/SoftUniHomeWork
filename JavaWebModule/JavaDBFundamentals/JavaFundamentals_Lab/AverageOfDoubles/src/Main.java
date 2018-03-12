import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.List;
import java.util.OptionalDouble;
import java.util.stream.DoubleStream;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<String> doubles = Arrays.asList(reader.readLine().split("\\s+"));

        DoubleStream mapped = doubles.stream().filter(x-> !x.isEmpty()).mapToDouble(Double::parseDouble);

        OptionalDouble num = mapped.average();

        if (num.isPresent()){
            System.out.printf("%.2f",num.getAsDouble());
        }else{
            System.out.println("No match");
        }
    }
}
