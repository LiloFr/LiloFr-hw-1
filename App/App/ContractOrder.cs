using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class ContractOrder
    {
        Check check;

        public ContractOrder(Check check)
        {
            this.check = check;
        }

        public Service Service { get; set; }
        public DirectiveForm DirectiveForm { get; set; }

    }
}
