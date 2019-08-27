using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3tworkTest
{
    public interface IPrimes
    {
        int[] CalculatePrimes(int amount);
    }

    class primes : IPrimes
    {

    }
}
