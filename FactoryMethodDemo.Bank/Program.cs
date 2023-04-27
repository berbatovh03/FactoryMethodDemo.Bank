using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternDemo
{
    internal class program
    {
        static void Main(string[] args)
        {
            BankFactory factory = new BankFactory();
            Bank tpb = factory.GetBank(BankType.TPBANK);
            Bank vcb = factory.GetBank(BankType.VIETCOMBANK);

            Console.WriteLine(tpb.GetBankName());
            Console.WriteLine(vcb.GetBankName());

            Console.ReadKey();
        }
    }
}