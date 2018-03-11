import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] arguments = reader.readLine().split(" ");
        Circle a = new Circle();
        a.setRadius(Integer.parseInt(arguments[2]));
        Point aCenter = new Point();
        aCenter.setX(Integer.parseInt(arguments[0]));
        aCenter.setY(Integer.parseInt(arguments[1]));
        a.setCenter(aCenter);


        arguments = reader.readLine().split(" ");
        Circle b = new Circle();
        b.setRadius(Integer.parseInt(arguments[2]));
        Point bCenter = new Point();
        bCenter.setX(Integer.parseInt(arguments[0]));
        bCenter.setY(Integer.parseInt(arguments[1]));
        b.setCenter(bCenter);

        if (a.intersect(b)){
            System.out.println("Yes");
        }else{
            System.out.println("No");
        }

    }
}
