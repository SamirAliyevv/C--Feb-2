using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Product product1 = new Product
            {
                Name = "Atena 10 kg Qatig",
                Price = 40
                



            };
            Product product2 = new Product
            {
                Name = "Milla",
                Price = 2.50


            };
            Drink drink = new Drink
            {
                Name="Nemiroff",
                Price=45,
                AlcoholPercent=30


            };
            Drink drink2 = new Drink
            {
                Name = "JackDaniels",
                Price = 180,
                AlcoholPercent = 60



            };



              store.AddProduct( product1);
            store.AddProduct(product2);
            store.AddProduct(drink);
            store.AddProduct(drink2);

            

        }
    }
}
