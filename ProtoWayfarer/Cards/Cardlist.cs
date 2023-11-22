using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWayfarer.Cards
{
    public class Cardlist : List<Card>
    {
        public Cardlist(String nameOfList) {
            this.NameOfList = nameOfList;
        }
        public String NameOfList { private set; get; }

    }
}
