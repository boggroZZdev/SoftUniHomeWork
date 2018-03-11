import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int count = Integer.parseInt(reader.readLine());

        Library current = new Library();
        current.setName("Whatever");
        ArrayList<Book> books = new ArrayList<>();
        current.setAllBooks(books);

        for (int i = 0; i < count ; i++) {
            String[] argums = reader.readLine().split(" ");
            Book book = new Book();
            book.setName(argums[0]);
            book.setAuthor(argums[1]);
            book.setPublisher(argums[2]);
            book.setPublished(argums[3]);
            book.setISBNumber(argums[4]);
            book.setPrice(Double.parseDouble(argums[5]));
            current.addBook(book);
        }

        TreeMap<String, Double> finalPrint = new TreeMap<>();

        for (Book book: books) {
            double price = book.price;
            if (finalPrint.containsKey(book.author)){
               price = finalPrint.get(book.author)+price;
               finalPrint.put(book.author,price);
            }else{
                finalPrint.put(book.author,price);
            }
        }

        for (String string: finalPrint.keySet()
                .stream()
                .sorted((x,y)->finalPrint.get(y).compareTo(finalPrint.get(x)))
                .collect(Collectors.toList())){
            System.out.printf("%s -> %.2f\r\n",string, finalPrint.get(string));
        }


    }
}
