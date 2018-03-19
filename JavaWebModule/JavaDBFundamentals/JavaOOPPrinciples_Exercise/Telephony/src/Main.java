import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] numbers = reader.readLine().split(" ");

        String[] urls = reader.readLine().split(" ");

        Smartphone ph = new Smartphone();

        Arrays.stream(numbers).forEach(ph::call);

        Arrays.stream(urls).forEach(ph::browse);

    }
}
