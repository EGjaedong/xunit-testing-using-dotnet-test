using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2 && candidate < 10)
            {
                return false;
            }

            return true;
        }
    }
}