using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    internal interface ICalcInterest
    {
        public int Calculate(int principle, int RateOfInt, int years);
   
    }
}
