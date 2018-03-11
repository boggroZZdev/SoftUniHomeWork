import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;


public class FitStringIn20Chars {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = reader.readLine();

        if (input.length()<20){
            StringBuilder sb = new StringBuilder(input);
            int toAdd = 20 - sb.length();
            for (int i = 0; i <toAdd ; i++) {
                sb.append('*');
            }
            System.out.println(sb);

        }else{
            System.out.println(input.substring(0,20));
        }



    }
}
