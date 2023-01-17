using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class PrimaryTube
    {
        List<Service> services = new List<Service>();
        List<DirectiveForm> forms = new List<DirectiveForm>();
        Biomaterial biomaterial;
        Consumable consumable;
        Sticker sticker;

        public PrimaryTube()
        {
            biomaterial = new Biomaterial();
            consumable = new Consumable();
            sticker = new Sticker();

        }
    }
}
