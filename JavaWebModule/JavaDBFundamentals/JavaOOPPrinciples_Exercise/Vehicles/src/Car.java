public class Car extends Vehicles {


    public Car(Double fuel, Double litersPerKm) {
        super(fuel, litersPerKm);
    }

    public Double getFuel() {
        return super.fuel;
    }

    public Double getLitersPerKm() {
        return super.litersPerKm+0.9;
    }

    @Override
    public void drive(Double distance) {
        if (distance*getLitersPerKm()>getFuel()){
            System.out.println("Car needs refueling");
        }else{
            System.out.printf("Car travelled %s km\r\n",dc.format(distance));
            super.fuel-=distance*getLitersPerKm();
        }
    }

    @Override
    public void refuel(Double value) {
        super.fuel += value;
    }
}
