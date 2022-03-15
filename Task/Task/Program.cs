using System;
using System.Collections;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1ci versiya
            //Lemon lemon = new Lemon(10, 15);
            //Apple apple = new Apple(0, 125);
            //Pineapple pineapple = new Pineapple(35, 5);

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(lemon);
            //arrayList.Add(apple);
            //arrayList.Add(pineapple);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2ci versiya

            Fruit lemon = new Lemon(10, 15);
            Fruit pineapple = new Pineapple(35, 5);
            Fruit apple = new Apple(0, 125);
            List<Fruit> Basket = new List<Fruit>();
            Basket.Add(lemon);
            Basket.Add(pineapple);
            Basket.Add(apple);
            foreach (Fruit fruit in Basket)
            {
                Console.WriteLine(fruit);
            }
            #endregion
        }
    }
}
