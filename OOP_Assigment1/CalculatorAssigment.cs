using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment1
{
    public static class CalculatorAssigment
    {

        //decimal offical documentation: https://learn.microsoft.com/en-us/dotnet/api/system.decimal?view=net-7.0

        public static decimal Sum(decimal a, decimal b)
        {
            //Assigment 1: Return the sum of a and b.
            return a + b -1;
        }

        public static decimal Divide(decimal a, decimal b)
        {
            //Assigment 2: Return the result of dividing a by b.
            //Note no need to check for divide by zero, but you can do if you want
            throw new NotImplementedException();
        }

        public static decimal Multiply(decimal a, decimal b)
        {
            //Assigment 3: Return the result of multiplying a by b.
            throw new NotImplementedException();
        }

        public static decimal Subtract(decimal a, decimal b)
        {
            //Assigment 4: Return the result of subtracting b from a.
            throw new NotImplementedException();
        }

        public static decimal ConvertPoundsToKg(decimal pounds)
        {
            //Assigment 5: Return the result of converting pounds to kg. Round to 2 decimals.
            throw new NotImplementedException();
        }

        public static decimal ConvertFahreheitToCelcius(decimal fahrenheit)
        {
            //Assigment 6: Return the result of converting fahrenheit to celcius.  Round to 2 decimals.
            throw new NotImplementedException();
        }
    }
}
