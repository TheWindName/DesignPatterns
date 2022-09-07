using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Tiger : Animal
    {
        string animalState;

        public Tiger()
        {
            this.animalState = "Quiet";
        }

        void Animal.eat(string food)
        {
            this.animalState = "Eating";
            Console.WriteLine("Tiger is eating " + food);
        }

        void Animal.state()
        {
            Console.WriteLine(this.animalState);
        }

        void Animal.move()
        {
            this.animalState = "Moving";
            Console.WriteLine("The Tiger is moving ....");
        }
    }
}
