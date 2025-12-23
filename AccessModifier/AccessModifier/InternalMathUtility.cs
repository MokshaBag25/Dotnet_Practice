using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class InternalMathUtility : CalculatorBase
    {
        public void CheckAccess()
        {
            Console.WriteLine(BrandName);
            Console.WriteLine(BasicMathCalc);
            Console.WriteLine(password);
        }
    }
}
