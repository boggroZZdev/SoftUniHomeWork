import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<String> ids = new ArrayList<>();

        while (true){
            String[] info = reader.readLine().split(" ");

            if (info.length==2){
                String rName = info[0];
                String rId = info[1];
                ids.add(rId);
            }else if(info.length==3){
                String cName = info[0];
                Integer cAge = Integer.parseInt(info[1]);
                String cId = info[2];
                ids.add(cId);
            }else if(info[0].equals("End")){
                break;
            }
        }

        String ender = reader.readLine();

        ids.stream().filter(x-> x.endsWith(ender)).forEach(System.out::println);
    }
}
