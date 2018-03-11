import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CensorEmailAddress {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String email = reader.readLine();

        String message = reader.readLine();

        String username = email.substring(0,email.indexOf('@'));
        String domain = email.substring(email.indexOf('@'), email.length());

        StringBuilder sb = new StringBuilder(email.length());

        for (int i = 0; i < username.length() ; i++) {
            sb.append('*');
        }
        sb.append(domain);
        String emails = sb.toString();
        String reworkedMessage = message.replaceAll(email,emails);

        System.out.println(reworkedMessage);
    }
}
