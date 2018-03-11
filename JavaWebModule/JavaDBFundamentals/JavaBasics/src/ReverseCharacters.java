import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ReverseCharacters {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 3 ; i++) {
            String character = reader.readLine();
            sb.append(character);
        }

        String output = sb.reverse().toString();

        System.out.println(output);
    }
}
