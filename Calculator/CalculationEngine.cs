using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class CalculationEngine
    {
        public int DoMath(string stuffToCalculate)
        {
            try
            {
                //throw new NotImplementedException();
                var splitNumbers = stuffToCalculate.Split('+')
                    .Select(int.Parse);
                //int firstNumber = int.Parse(splitNumbers[0]);
                //int secondNumber = int.Parse(splitNumbers[1]);

                //var result = 0;
                //foreach (var number in splitNumbers)
                //{
                //    result += number;
                //}

                //return result;
                return splitNumbers.Sum();
            }
            catch(FormatException)
            {
                throw new InvalidInputException(); 
            }
            
        }
    }
}
