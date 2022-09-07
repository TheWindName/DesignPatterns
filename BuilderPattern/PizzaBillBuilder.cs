using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class PizzaBillBuilder : IBuilder
    {
        PizzaBill bill;

        public PizzaBillBuilder()
        {
            bill = new PizzaBill();
        }

        void IBuilder.reset()
        {
            bill = new PizzaBill();
        }

        void IBuilder.setCheese()
        {
            bill.ingredientPrice.Add("Cheese", 1);

            Console.WriteLine("Take note with Cheese ...");
        }

        void IBuilder.setBacon()
        {
            bill.ingredientPrice.Add("Bacon", 1);

            Console.WriteLine("Take note with Bacon ...");
        }

        void IBuilder.setTomato()
        {
            bill.ingredientPrice.Add("Tomato", 1);

            Console.WriteLine("Take note with Tomato ...");
        }

        void IBuilder.setPepperoni()
        {
            bill.ingredientPrice.Add("Pepperoni", 1);

            Console.WriteLine("Take note with Pepperoni ...");
        }

        void IBuilder.setHam()
        {
            bill.ingredientPrice.Add("Ham", 1);

            Console.WriteLine("Take note with Ham ...");
        }
    }
}
