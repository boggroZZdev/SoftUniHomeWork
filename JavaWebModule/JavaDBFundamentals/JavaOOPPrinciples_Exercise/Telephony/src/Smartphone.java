public class Smartphone implements Phone,Browser {

    @Override
    public void browse(String url) {
        if (isURL(url)){
            System.out.printf("Browsing: %s!\r\n",url);
        }else{
            System.out.println("Invalid URL!");
        }
    }

    public Smartphone() {
    }

    @Override
    public boolean isURL(String url) {
        for (char c: url.toCharArray()) {
            if (Character.isDigit(c)){
                return false;
            }
        }
        return true;
    }

    @Override
    public void call(String number) {
        if (isPhonenumber(number)){
            System.out.printf("Calling... %s\r\n", number);
        }else{
            System.out.println("Invalid number!");
        }
    }

    @Override
    public boolean isPhonenumber(String num) {
        for (char c: num.toCharArray()) {
            if (!Character.isDigit(c)){
                return false;
            }
        }
        return true;
    }
}
