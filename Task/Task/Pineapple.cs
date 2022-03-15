using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Pineapple: Fruit 
    { 
    
        public Pineapple(int vitA, int vitC) : base(vitA, vitC)
        {

        }
        public override string ToString()
        {
            return "Pineapple" + " " + VitaminA + " " + VitaminC;
        }
    }
}

