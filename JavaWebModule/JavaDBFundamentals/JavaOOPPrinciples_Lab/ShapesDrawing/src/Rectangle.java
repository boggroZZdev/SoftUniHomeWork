public class Rectangle implements Drawable{
    private Integer height;
    private Integer width;

    @Override
    public void draw() {
        for (int i = 0; i< height; i++){
            System.out.print("*");
            for (int k = 1; k < width-1; k++){
                System.out.print(" ");
                if (i==0 || i == (height-1)) {
                    System.out.print("*");
                }else{
                    System.out.print(" ");
                }
            }
            System.out.print(" *\r\n");
        }
    }

    public Rectangle(Integer height, Integer width) {
        this.height = height;
        this.width = width;
    }
}
