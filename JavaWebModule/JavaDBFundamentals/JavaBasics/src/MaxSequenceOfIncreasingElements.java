import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] input = Arrays.stream(reader.readLine().split(" "))
        .mapToInt(Integer::parseInt)
                .toArray();

        int start = 0;
        int len = 1;
        int currentLen = 1;
        int bestStart = 0;

        for (int i = 1; i < input.length  ; i++) {
            if (input[i] > input[i-1]){
                currentLen++;
                if (currentLen>len){
                    len = currentLen;
                    bestStart = start;
                }
            }else{
                currentLen = 1;
                start = i;
            }
        }

        for (int i = bestStart; i < bestStart + len; i++) {
            System.out.printf("%d ", input[i]);
        }
    }
}
