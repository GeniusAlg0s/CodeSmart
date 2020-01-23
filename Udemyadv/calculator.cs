using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    public class calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
