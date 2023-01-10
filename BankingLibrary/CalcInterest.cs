using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    internal class CalcInterest : ICalcInterest
    {
        public int Calculate(int principle, int RateOfInt, int years)
        {

            int SimpInt = (principle * years * RateOfInt) / 100;
            return SimpInt;

        }
    }
}
