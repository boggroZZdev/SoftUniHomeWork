import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.TreeMap;

public class PhonebookUpgrade {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = reader.readLine();

        TreeMap<String,String> phonebook = new TreeMap<>();


        while(!input.equals("END")){
            String[] argums = input.split(" ");
            String value = argums[0];

            if (value.equals("A")){
                String name = argums[1];
                String phonenumber = argums[2];
                phonebook.put(name,phonenumber);
            }else if(value.equals("S")){
                String name = argums[1];
                if (phonebook.containsKey(name)){
                    System.out.printf("%s -> %s\r\n", name,phonebook.get(name));
                }else{
                    System.out.printf("Contact %s does not exist.\r\n", name);
                }
            }else if (value.equals("ListAll")){
                for (String key : phonebook.keySet()){
                    System.out.printf("%s -> %s\r\n",key, phonebook.get(key));
                }
            }

            input = reader.readLine();
        }
    }
}
