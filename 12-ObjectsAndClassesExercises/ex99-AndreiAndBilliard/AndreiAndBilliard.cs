using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex99_AndreiAndBilliard
{
    class AndreiAndBilliard
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();

            int productsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productsCount ; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string productName = input[0];
                decimal productPrice = decimal.Parse(input[1]);

                if (!productsPrice.ContainsKey(productName))
                {
                    productsPrice.Add(productName, productPrice);
                }

                productsPrice[productName] = productPrice;
            }

            string inputLine = Console.ReadLine();
            List<Customer> customers = new List<Customer>();
            while (!inputLine.Equals("end of clients"))
            {
                string[] costumerInfo = inputLine.Split(',', '-');
                string customerName = costumerInfo[0];
                string customerProduct = costumerInfo[1];
                int quantity = int.Parse(costumerInfo[2]);

                if (!productsPrice.ContainsKey(customerProduct))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (customers.Any(c => c.Name == customerName))
                {
                    Customer customer = customers.First(c => c.Name == customerName);
                    if (!customer.OrdersQuantity.ContainsKey(customerProduct))
                    {
                        customer.OrdersQuantity.Add(customerProduct, quantity);
                    }
                    else
                    {
                        customer.OrdersQuantity[customerProduct] += quantity;
                    }
                    customer.Bill += quantity * productsPrice[customerProduct];
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.OrdersQuantity = new Dictionary<string, int>();
                    customer.OrdersQuantity.Add(customerProduct, quantity);
                    customer.Bill += quantity * productsPrice[customerProduct];
                    customers.Add(customer);
                }

                inputLine = Console.ReadLine();
            }

            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach(var customerOrders in customer.OrdersQuantity)
                {
                    Console.WriteLine("-- {0} - {1}", customerOrders.Key, customerOrders.Value);
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);
            }

            decimal totalBill = customers.Sum(c => c.Bill);
            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }

        public class Customer
        {
            public string Name { get; set; }

            public Dictionary<string, int> OrdersQuantity { get; set; }

            public decimal Bill { get; set; }
        }
    }
}
