public class Truck extends Vehicles{


    public Truck(Double fuel, Double litersPerKm) {
        super(fuel, litersPerKm);
    }

    public Double getFuel(){
        return super.fuel;
    }

    public Double getLitersPerKilometer(){
        return super.litersPerKm+1.6;
    }


    @Override
    public void drive(Double distance) {
        if (distance*getLitersPerKilometer()>getFuel()){
            System.out.println("Truck needs refueling");
        }else{
            System.out.printf("Truck travelled %s km\r\n",dc.format(distance));
            super.fuel-= distance*getLitersPerKilometer();
        }
    }

    @Override
    public void refuel(Double kilometres) {
        super.fuel += kilometres*0.95;
    }
}
