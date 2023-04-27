using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternDemo
{
    internal class BankFactory : BankCreator
    {
        public override Bank GetBank(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.TPBANK:
                    return new TPBank();

                case BankType.VIETCOMBANK:
                    return new Vietcombank();

                case BankType.ACB:
                    return new ACB();

                default:
                    return null;
            }
        }
    }
}
