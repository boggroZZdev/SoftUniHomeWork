import java.util.ArrayList;
import java.util.List;

public class Library {
    public String name;

    public Library() {
        this.allBooks = new ArrayList<>();
    }

    public ArrayList<Book> allBooks;

    public void setAllBooks(ArrayList<Book> allBooks) {
        this.allBooks = allBooks;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void addBook(Book b){
        this.allBooks.add(b);
    }
}
