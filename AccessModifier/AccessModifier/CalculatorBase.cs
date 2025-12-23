using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class CalculatorBase
    {
        public string BrandName = "Casio";
        private string _serialCode = "A-101";
        protected string BasicMathCalc = "Standard Calc";
        internal string password = "Admin123";
    }
}
