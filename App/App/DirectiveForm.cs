using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class DirectiveForm
    {
        List<Service> ServicesList = new List<Service>();
        List<PrimaryTube> primaryTubes = new List<PrimaryTube>();
        public ResearchOrder ResearchOrder { get; set; }
        public int Id { get; set; }
        

    }
}
