using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07_AndreyAndBilliard
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string input)
        {
            string[] splitted = input.Split('-').ToArray();
            Name = splitted[0];
            Price = decimal.Parse(splitted[1]);
        }
    }

    class Client
    {
        public string Name { get; set; }
        public Dictionary<string, int>  ProductsList { get; set; }

        public decimal Bill
        {
            get; set;
        }
    }
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictPriceList = FillProdDictionary(n);

            List<Client> clientBills = new List<Client>();
            string input = Console.ReadLine();
  
            while (!input.Equals("end of clients"))
            {
                string[] inputData = input.Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputData[0];
                string prod = inputData[1];
                int quantity = int.Parse(inputData[2]);

                // check if the product from input exist in dictPriceList
                if (!dictPriceList.ContainsKey(prod))
                {
                    input = Console.ReadLine();
                    continue;
                }

                // check if such name exist in list "clientBills"
                if (clientBills.Any(c => c.Name == name))
                {
                    Client client = clientBills.First(c => c.Name == name);
                    if (!client.ProductsList.ContainsKey(prod))
                    {
                        client.ProductsList.Add(name, quantity);
                    }
                    else
                    {
                        client.ProductsList[prod] += quantity;
                    }

                    client.Bill += quantity * dictPriceList[prod];
                    clientBills.Add(client);
                }

                else
                {
                    Client client = new Client();
                    client.Name = name;
                    client.ProductsList = new Dictionary<string, int>();
                    client.ProductsList.Add(prod, quantity);
                    client.Bill += quantity * dictPriceList[prod];
                    clientBills.Add(client);
                }


                input = Console.ReadLine();
            }


            foreach (var client in clientBills.OrderBy(name => name.Name))
            {
                Console.WriteLine(client.Name);
                foreach (var orders in client.ProductsList)
                {
                    Console.WriteLine("-- {0} - {1}", orders.Key, orders.Value);
                }
                Console.WriteLine("Bill: {0:f2}", client.Bill);
            }
            decimal totalBill = clientBills.Sum(c => c.Bill);

            Console.WriteLine("Total bill: {0:f2}", totalBill);


        }

        private static Dictionary<string, decimal> FillProdDictionary(int n)
        {
            var prodDict = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var product = new Product(Console.ReadLine());
                if (!prodDict.ContainsKey(product.Name))
                {
                    prodDict.Add(product.Name, product.Price);
                }
                else
                {
                    prodDict[product.Name] = product.Price;
                }
            }

            return prodDict;
        }
    }
}
