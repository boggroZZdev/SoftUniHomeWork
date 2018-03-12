import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.List;
import java.util.Optional;
import java.util.OptionalDouble;
import java.util.stream.DoubleStream;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<String> entries = Arrays.asList(reader.readLine().split("\\s+"));

        Optional<Double> min = entries
                .stream()
                .filter(x-> !x.isEmpty())
                .map(Double::parseDouble)
                .filter(x-> x%2 == 0)
                .min(Double::compare);

        if (min.isPresent()){
            System.out.printf("%.2f", min.get());
        }else{
            System.out.println("No match");
        }
    }
}
