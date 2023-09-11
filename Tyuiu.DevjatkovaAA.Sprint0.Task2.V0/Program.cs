using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DevjatkovaAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и меода GetMessage
            //из библиотеки Tyuiu.DevjatkovaAA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Анастасия"));
            Console.ReadKey();
        }
    }
}
