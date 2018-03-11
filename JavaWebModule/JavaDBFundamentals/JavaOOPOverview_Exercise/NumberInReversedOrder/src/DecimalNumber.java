public class DecimalNumber {

    public String decimalNumber;

    public void setDecimalNumber(String decimalNumber) {
        this.decimalNumber = decimalNumber;
    }

    public void reverseString(){
        String string = this.decimalNumber;
        string = new StringBuilder(string).reverse().toString();
        System.out.println(string);
    }
}
