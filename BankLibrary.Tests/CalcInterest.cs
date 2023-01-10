namespace BankLibrary.Tests
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