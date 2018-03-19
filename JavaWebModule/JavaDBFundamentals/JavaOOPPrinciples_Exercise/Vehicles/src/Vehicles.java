import java.text.DecimalFormat;

public abstract class Vehicles implements Vehicle{
    Double fuel;
    Double litersPerKm;
    DecimalFormat dc = new DecimalFormat("#.################");

    public Vehicles(Double fuel, Double litersPerKm) {
        this.fuel = fuel;
        this.litersPerKm = litersPerKm;
    }


    public Double getFuel() {
        return fuel;
    }

    public Double getLitersPerKm() {
        return litersPerKm;
    }
}
