import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        List<LivingBeing> beings = new ArrayList<>();


        while (true) {
            String[] info = reader.readLine().split("\\s+");

            if (info[0].equals("Citizen")){
                String name = info[1];
                Integer age = Integer.parseInt(info[2]);
                String id = info[3];
                String birthday = info[4];

                Citizen c = new Citizen(name,birthday);
                beings.add(c);

            }else if(info[0].equals("Pet")){
                String name = info[1];
                String birthday = info[2];
                Pet p = new Pet(name,birthday);
                beings.add(p);
            }else if(info[0].equals("Robot")){
                String model = info[1];
                String id = info[2];
                Robot r = new Robot(model,id);
            }else if(info[0].equals("End")){
                break;
            }
        }

        String ender = reader.readLine();

        beings.stream()
                .filter(x-> x.getBirthdayDate().endsWith(ender))
                .forEach(x-> System.out.println(x.getBirthdayDate()));
    }
}
