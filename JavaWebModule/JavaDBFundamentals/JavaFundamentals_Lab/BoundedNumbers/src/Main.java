import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Integer> bounds = Arrays
                .stream(reader.readLine()
                .split("\\s+"))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        List<Integer> numbers = Arrays
                .stream(reader.readLine()
                .split("\\s+"))
                .map(Integer::parseInt)
                .filter(x->Collections.min(bounds) <= x && x<= Collections.max(bounds))
                .collect(Collectors.toList());


        numbers.forEach(x-> System.out.print(x+" "));


    }
}
