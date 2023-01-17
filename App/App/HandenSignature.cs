using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class HandedSignature : Sticker
    {
        public string Fullname { get; set; }
        public string Barcode { get; set; }
        public int TudeId { get; set; }
        public string CollectionDate { get; set; }
    }
}
