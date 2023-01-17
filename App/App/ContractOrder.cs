using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class ContractOrder
    {
        List<Service> ServicesList = new List<Service>();
        public ResearchOrder ResearchOrder { get; set; }
        public string OrderDate { get; set; }
        public int Id { get; set; }
        public int DetailsPatietns { get; set; }
        public int ClinicDetails { get; set; }
        public int Sum {  get; set; }
        public string ExecutionDate {  get; set; }
        Check check;
        public ContractOrder(Check check)
        {
            this.check = check;
        }

        
        

    }
}
