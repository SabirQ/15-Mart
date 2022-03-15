using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Apple : Fruit
    {

        public Apple(int vitA, int vitC) : base(vitA, vitC)
        {

        }
        public override string ToString()
        {
            return "Apple" + " " + VitaminA + " " + VitaminC;
        }
    }
    
    
}
