import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class MostFrequentNumber {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] input = Arrays.stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();


        int currentDigit = 0;
        int maxCount = 0;

        int maxDigit = currentDigit;

        for (int i = 0; i < input.length; i++) {
            int currentCount = 0;
            for (int j = i; j < input.length ; j++) {
                if (input[i] == input[j]){
                    currentCount++;
                    if (currentCount>maxCount){
                        maxCount = currentCount;
                        maxDigit = input[j];
                    }
                }
            }
        }

        System.out.println(maxDigit);

    }
}
