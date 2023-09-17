using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DevjatkovaAA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        //Пример циклической структуры (цикл с параметрами) for
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resulArray = new int[5];
            for (var i = 0; i < resulArray.Length; i++)
            {
                resulArray[i] = numOne[i] + numTwo[i];
            }
            return resulArray;
        }
    }
}
