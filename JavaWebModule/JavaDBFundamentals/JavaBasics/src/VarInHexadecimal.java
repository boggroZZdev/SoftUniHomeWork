import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class VarInHexadecimal {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = reader.readLine();

        int whatever = Integer.parseInt(input,16);

        System.out.println(whatever);
    }
}
