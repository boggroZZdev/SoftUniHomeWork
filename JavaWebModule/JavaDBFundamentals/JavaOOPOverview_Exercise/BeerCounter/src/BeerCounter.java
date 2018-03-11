public class BeerCounter {

    private static int beerInStock = 0;
    private static int beerDrankCount = 0;

    public static void buyBeer(int bottlesCount) {
        beerInStock += bottlesCount;
    }

    public static void drinkBeer(int bottlesCount) {
        beerDrankCount += bottlesCount;
        beerInStock -= bottlesCount;
    }

    public static void printResult() {
        System.out.printf("%d %d", beerInStock, beerDrankCount);
    }

}
