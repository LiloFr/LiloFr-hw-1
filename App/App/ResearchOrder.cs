using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class ResearchOrder
    {
        List<DirectiveForm> forms = new List<DirectiveForm>();
        List<PrimaryTube> primaryTubes = new List<PrimaryTube>();
        List<ResearchOrder> researchOrders = new List<ResearchOrder>();
    }
}
