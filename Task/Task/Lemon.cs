using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Lemon : Fruit
    {
        public Lemon(int vitA,int vitC):base(vitA,vitC)
        {

        }
        public override string ToString()
        {
            return "Lemon"+" "+VitaminA+" "+VitaminC;
        }
    }
}
