import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CompareCharArrays {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String first = reader.readLine().replaceAll(" ","");
        String second = reader.readLine().replaceAll(" ","");

        int lowestLenght = Math.min(first.length(), second.length());

        for (int i = 0; i < lowestLenght; i++) {
            if (first.charAt(i) < second.charAt(i)){
                System.out.println(first);
                System.out.println(second);
                return;
            }else if (first.charAt(i) > second.charAt(i)){
                System.out.println(second);
                System.out.println(first);
                return;
            }
        }

        if (first.length()>second.length()){
            System.out.println(second);
            System.out.println(first);
        }else if(first.length()<second.length()){
            System.out.println(first);
            System.out.println(second);
        }else{
            System.out.println(first);
            System.out.println(first);
        }

    }
}
