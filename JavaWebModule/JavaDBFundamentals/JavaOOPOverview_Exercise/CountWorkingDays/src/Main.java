import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.text.ParseException;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;


public class Main {
    private final static Set<String> HOLIDAYS = new HashSet<>(Arrays.asList(
            "01-01","03-03","01-05","06-05","24-05","06-09","22-09","01-11","24-12","25-12","26-12"
    ));

    private final static DateTimeFormatter INPUT_DATE_FORMAT = DateTimeFormatter.ofPattern("dd-MM-yyyy");
    private final static DateTimeFormatter DAY_MONTH_FORMAT = DateTimeFormatter.ofPattern("dd-MM");


    public static void main(String[] args) throws IOException, ParseException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        LocalDate startDate =  LocalDate.parse(reader.readLine(),INPUT_DATE_FORMAT);
        LocalDate secondDate = LocalDate.parse(reader.readLine(),INPUT_DATE_FORMAT);
        int workdays  = 0;

        while (!startDate.isAfter(secondDate)){
            if (isWorkday(startDate)){
                workdays++;
            }
            startDate = startDate.plusDays(1);
        }

        System.out.println(workdays);
    }


    private static boolean isWorkday(LocalDate date){
        DayOfWeek dayOfWeek = date.getDayOfWeek();

        return dayOfWeek != DayOfWeek.SATURDAY && dayOfWeek != DayOfWeek.SUNDAY
                && !HOLIDAYS.contains(date.format(DAY_MONTH_FORMAT));
    }
}
