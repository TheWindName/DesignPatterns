using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class PizzaBuilder : IBuilder
    {
        Pizza pizza;

        public PizzaBuilder()
        {
            pizza = new Pizza();
        }

        void IBuilder.reset()
        {
            pizza = new Pizza();
        }

        void IBuilder.setCheese()
        {
            pizza.ingredient.Add("Cheese");

            Console.WriteLine("Drop Cheese ...");
        }

        void IBuilder.setBacon()
        {
            pizza.ingredient.Add("Bacon");

            Console.WriteLine("Drop Bacon ...");
        }

        void IBuilder.setTomato()
        {
            pizza.ingredient.Add("Tomato");

            Console.WriteLine("Drop Tomato ...");
        }

        void IBuilder.setPepperoni()
        {
            pizza.ingredient.Add("Pepperoni");

            Console.WriteLine("Drop Pepperoni ...");
        }

        void IBuilder.setHam()
        {
            pizza.ingredient.Add("Ham");

            Console.WriteLine("Drop Ham ...");
        }
    }
}
