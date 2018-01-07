import java.util.Scanner;

public class symmetricNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <= n; i++) {
            if (isSymmetric(Integer.toString(i))){
                System.out.print(i+" ");
            }
        }
    }

    static boolean isSymmetric(String ind) {
        for (int i = 0; i < ind.length()/2 ; i++) {
            if (ind.charAt(i) != ind.charAt(ind.length()-1-i)){
                return false;
            }
        }
        return true;
    }
}
