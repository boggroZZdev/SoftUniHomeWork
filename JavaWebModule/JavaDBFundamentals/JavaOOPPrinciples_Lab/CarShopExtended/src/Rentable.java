public class Rentable implements Car {
    private Integer minRentDays;
    private Double pricePerDay;
    private String model;
    private String color;
    private Integer horsePower;
    private String countryProduced;

    public String getCountryProduced() {
        return countryProduced;
    }

    public Rentable(String model, String color, Integer horsePower, Integer minRentDays, Double pricePerDay) {
        this.minRentDays = minRentDays;
        this.pricePerDay = pricePerDay;
        this.model = model;
        this.color = color;
        this.horsePower = horsePower;
    }

    public Integer getMinRentDays() {
        return minRentDays;
    }

    public Double getPricePerDay() {
        return pricePerDay;
    }

    @Override
    public String getModel() {
        return this.model;
    }

    @Override
    public String getColor() {
        return this.color;
    }

    @Override
    public Integer getHorsePower() {
        return this.horsePower;
    }

    @Override
    public String toString() {
        return String.format("This is %s produced in %s and have %d tires", getModel(),getCountryProduced(),TIRES);
    }


}
