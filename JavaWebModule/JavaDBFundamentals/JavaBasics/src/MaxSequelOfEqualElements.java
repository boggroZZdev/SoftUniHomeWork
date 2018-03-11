import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class MaxSequelOfEqualElements {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] input = Arrays.stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int charAt = input[0];
        int maxCharAt = input[0];
        int max = 1;
        int currentCount = 1;

        for (int i = 1; i < input.length ; i++) {

            if (input[i] == input[i-1]){
                currentCount++;
                if (currentCount>max){
                    max = currentCount;
                    maxCharAt = input[i];
                }
            }else{
                currentCount = 1;
            }
        }

        for (int i = 0; i < max ; i++) {
            System.out.printf("%d ", maxCharAt);
        }

    }
}
