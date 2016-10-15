using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07_SalesReport
{

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sale ReadSale(string input)
        {
            Sale data = new Sale();
            string[] parameters = input.Split(' ').ToArray();

            data.Town = parameters[0];
            data.Product = parameters[1];
            data.Price = decimal.Parse(parameters[2]);
            data.Quantity = decimal.Parse(parameters[3]);

            return data;
        }

    }


        class SalesReport
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = new Sale();
                sale = Sale.ReadSale(Console.ReadLine());
                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown.Add(sale.Town, sale.Quantity * sale.Price);
                }
                else
                {
                    salesByTown[sale.Town] += sale.Quantity * sale.Price;
                }
            }

            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }
    }
}
