using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstDemo
{
    public class CRUD
    {
        Model1Container ob = new Model1Container();
        public void AddPizza()
        {
            Pizza p = new Pizza()
            {
                PizzaID = 200,
                PizzaName = "chicken tender",
                Description = "made with chicken",
                Price = 300,
                Type = "Non veg"
            };

            ob.Pizzas.Add(p);
            int i = ob.SaveChanges();
            Console.WriteLine("total record inserted is "+i);

            foreach (var item in ob.Pizzas)
            {
                Console.WriteLine($"{item.PizzaID}{item.PizzaName}{item.Price}{item.Type}{item.Description}");
            }
        }

        // extenstion methods

        public void EvenODD()
        {
            int x = 11;
            Console.WriteLine(x.IsEven());


        }

    }


    static class myclass
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }


    }
}
