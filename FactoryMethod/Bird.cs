using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Bird : Animal
    {
        string animalState;

        public Bird()
        {
            this.animalState = "Quiet";
        }

        void Animal.eat(string food)
        {
            this.animalState = "Eating";
            Console.WriteLine("Bird is eating " + food);
        }

        void Animal.state()
        {
            Console.WriteLine(this.animalState);
        }

        void Animal.move()
        {
            this.animalState = "Flying";
            Console.WriteLine("The Bird is flying ....");
        }
    }
}
