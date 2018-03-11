import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class EqualSums {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] input = Arrays.stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        if (input.length == 1){
            System.out.println("0");
            return;
        }

        Boolean isFound = false;
        int place = 0;

        for (int i = 0; i < input.length ; i++) {
            int leftSum = 0;
            int rightSum = 0;
            if (i == 0){
                for (int j = 1; j < input.length; j++) {
                    rightSum+= input[j];
                }
                if (rightSum==leftSum){
                    isFound = true;
                    place = i;
                    break;
                }
            }else if (i == input.length-1){
                for (int j = input.length-2; j >= 0 ; j--) {
                    leftSum+=input[j];
                }
                if (rightSum==leftSum){
                    isFound = true;
                    place = i;
                    break;
                }
            }else{
                for (int j = 0; j < i ; j++) {
                    leftSum += input[j];
                }
                for (int j = i+1; j < input.length ; j++) {
                    rightSum += input[j];
                }

                if (leftSum==rightSum){
                    isFound = true;
                    place = i;
                    break;
                }
            }

        }
        if (!isFound){
            System.out.println("no");
        }else{
            System.out.println(place);
        }
    }
}
