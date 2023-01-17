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
        List<ResearchOrder> researchOrder = new List<ResearchOrder>();
        public DirectiveForm DirectiveForm { get; set; }
    }
}
