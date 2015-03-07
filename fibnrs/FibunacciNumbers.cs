using System;

namespace fibnrs
{
    public class FibunacciNumbers
    {
        public int GetFibunacciNumber(int index)
        {
            if (index == 0)
                return 0;
            if (index == 1)
                return 1;
            return GetFibunacciNumber(index - 1) + GetFibunacciNumber(index - 2);
        }
    }
}