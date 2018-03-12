public class Book {
    public String name;
    public String author;
    public double price;

    public Book(String name,double price,String author) {
        this.name = name;
        this.author = author;
        this.price = price;
    }

    public String getAuthor() {
        return author;
    }

    public double getPrice() {
        return price;
    }
}
