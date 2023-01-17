using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Service
    {
        List<PrimaryTube> primaryTubes = new List<PrimaryTube>();
        List <ContractOrder> contractOrders = new List<ContractOrder>();
        public DirectiveForm DirectiveForm { get; set; }
    }
}
