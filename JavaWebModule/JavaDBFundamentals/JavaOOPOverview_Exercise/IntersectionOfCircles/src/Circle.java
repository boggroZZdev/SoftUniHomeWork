public class Circle {

    public Point center;
    public int radius;

    public Point getCenter() {
        return center;
    }

    public void setCenter(Point center) {
        this.center = center;
    }

    public int getRadius() {
        return radius;
    }

    public void setRadius(int radius) {
        this.radius = radius;
    }

    public boolean intersect(Circle b){
        Circle a = new Circle();
        a.setCenter(this.center);
        a.setRadius(this.radius);
        int distance = Math.abs(a.center.X-b.center.X);

        if (distance <= a.radius+b.radius){
            return true;
        }
        else{
            return false;
        }
    }
}
