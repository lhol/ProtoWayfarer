using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWayfarer.Cards
{
    internal class Itemcard : Card
    {
        public Itemcard(CardPrototype cp, int itemvalue) : base(cp)
        {
            this.itemvalue = itemvalue; 
        }

        public int itemvalue { get; set; }
    }
}
