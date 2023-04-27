using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternDemo
{
    internal abstract class Bank
    {
        protected long CardNumber { get; set; }
        protected string Cardname { get; set; }

        protected string ExpireDate { get; set; }

        public abstract string GetBankName();
    }
}
