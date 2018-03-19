import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] carInfo = reader.readLine().split("\\s+");
        Car car = new Car(Double.parseDouble(carInfo[1]),Double.parseDouble(carInfo[2]));

        String[] truckInfo = reader.readLine().split("\\s+");
        Truck truck = new Truck(Double.parseDouble(truckInfo[1]),Double.parseDouble(truckInfo[2]));

        int n = Integer.parseInt(reader.readLine());

        for (int i = 0; i < n ; i++) {
            String[] info = reader.readLine().split("\\s+");
            if (info[0].equals("Drive")){
                if (info[1].equals("Car")){
                    car.drive(Double.parseDouble(info[2]));
                }else if(info[1].equals("Truck")){
                    truck.drive(Double.parseDouble(info[2]));
                }
            }else if(info[0].equals("Refuel")){
                if (info[1].equals("Car")){
                    car.refuel(Double.parseDouble(info[2]));
                }else if(info[1].equals("Truck")){
                    truck.refuel(Double.parseDouble(info[2]));
                }
            }
        }

        System.out.printf("Car: %.2f\r\n",car.getFuel());
        System.out.printf("Truck: %.2f\r\n",truck.getFuel());
    }
}
