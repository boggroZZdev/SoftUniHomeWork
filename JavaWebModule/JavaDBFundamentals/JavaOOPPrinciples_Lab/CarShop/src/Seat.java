public class Seat implements Car {

    private String model;
    private String color;
    private Integer horsePower;
    private String coutryProduced;


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

    public Seat(String model, String color, Integer horsePower, String coutryProduced) {
        this.model = model;
        this.color = color;
        this.horsePower = horsePower;
        this.coutryProduced = coutryProduced;
    }


    @Override
    public String toString() {
        return String.format("%s is %s color and have %d horsepower\r\nThis %s is produced in %s and have %d tires",model,color,horsePower,model,coutryProduced,TIRES);
    }
}
