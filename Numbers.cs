using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        private int _i, _j;
        public int FindMinimum(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            _i = number1 < number3 ? number1 : (int)number3;
            _j = number2 < number3 ? number2 : (int)number3;
            return number1 < number2 ? _i : _j;
        }
        public int FindMaximum(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            _i = number1 > number3 ? number1 : (int)number3;
            _j = number2 > number3 ? number2 : (int)number3;
            return number1 > number2 ? _i : _j;
        }
    }
}
