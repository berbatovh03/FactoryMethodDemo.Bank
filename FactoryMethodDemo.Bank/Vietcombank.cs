using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternDemo
{
    internal class Vietcombank : Bank
    {
        public override string GetBankName()
        {
            return "VietcomBank";
        }
    }
}
