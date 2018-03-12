import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.List;
import java.util.Optional;
import java.util.Scanner;


public class Main {
    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Scanner scanner = new Scanner(System.in);
        List<String> names = Arrays.asList(reader.readLine().split("\\s+"));

        Character c = scanner.next().toLowerCase().charAt(0);


        Optional<String> name = names.stream()
                .filter(x-> x.toLowerCase().charAt(0) == c)
                .sorted()
                .findFirst();

        if (name.isPresent()){
            System.out.println(name.get());
        }else{
            System.out.println("No match");
        }
    }
}
