using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add("1994 PHP", "proggramming language");
            sortedList.Add("2000 C#", "proggramming language");
            sortedList.Add("1985 C++", "proggramming language");
            sortedList.Add("1985 A++", "proggramming language");    //bu case il eyni olduqda ada gore sort etdiyini gostermek ucun yazilib(melumat duzgun deyil)
            sortedList.Add("1991 Python", "proggramming language");
            sortedList.Add("1996 Java", "proggramming language");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
