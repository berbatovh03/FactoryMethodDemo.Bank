using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternDemo
{
    internal abstract class BankCreator
    {
        public abstract Bank GetBank(BankType bankType);
    }
    public enum BankType
    {
        VIETCOMBANK, TPBANK, ACB, SCB, SacomBank, ViettinBank
    }
}
