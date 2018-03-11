import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class IntegerToHexAndBinary {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int input = Integer.parseInt(reader.readLine());

        String hexa  = Integer.toHexString(input);

        String binary = Integer.toBinaryString(input);

        System.out.println(hexa.toUpperCase());
        System.out.println(binary);
    }
}
