using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] sales = new string[n];

            SortedDictionary<string, double> salesByTown = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSale(Console.ReadLine());
                sales[i] = sale.Town;
                if (salesByTown.ContainsKey(sales[i]))
                {
                    salesByTown[sales[i]] += sale.WholePrice;
                }
                else
                {
                    salesByTown.Add(sales[i], sale.WholePrice);
                }
            }

            var towns = sales.Distinct().OrderBy(x => x);

            foreach (var town in towns)
            {
                Console.WriteLine($"{town} -> {salesByTown[town]:F2}");
            }

        }

        public static Sale ReadSale(string input)
        {
            string[] array = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return new Sale() {Town = array[0],Product = array[1], Price = double.Parse(array[2]), Quantity = double.Parse(array[3]),WholePrice = double.Parse(array[2])* double.Parse(array[3])};
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double WholePrice { get; set; }
    }
}
