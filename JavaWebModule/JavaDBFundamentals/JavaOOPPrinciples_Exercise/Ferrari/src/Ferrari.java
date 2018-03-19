public class Ferrari implements Car {
   private String model = "488-Spider";
   private String driver;

    public Ferrari(String driver) {
        this.driver = driver;
    }

    public void getModel() {
        System.out.print(this.model+"/");
    }

    public void getDriver() {
        System.out.print(this.driver);
    }

    @Override
    public void gasPedal() {
        System.out.print("Zadu6avam sA!/");
    }

    @Override
    public void brakesPedal() {
        System.out.print("Brakes!/");
    }

    @Override
    public void print() {
        getModel();
        brakesPedal();
        gasPedal();
        getDriver();
    }
}
