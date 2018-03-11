import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class VowelOrDigit {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        char[] vowels = new char[] {'a','o','e','u','i'};
        char[] digits = new char[] {'1','2','3','4','5','6','7','8','9','0'};

        String input = reader.readLine();

        if (new String(vowels).contains(input)){
            System.out.println("vowel");
        }else if(new String(digits).contains(input)){
            System.out.println("digit");
        }else{
            System.out.println("other");
        }
    }
}
