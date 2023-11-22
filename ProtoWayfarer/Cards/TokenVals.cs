using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWayfarer.Cards
{
    public class TokenVals
    {
        public TokenVals(int min, int max, int initial, int basevalue, int currentvalue, int threasholdMin, int threasholdMax)
        {
            this.min = min;
            this.max = max;
            this.initial = initial;
            this.basevalue = basevalue;
            this.currentvalue = currentvalue;
            this.threasholdMin = threasholdMin;
            this.threasholdMax = threasholdMax;
        }
        public int min { get; set; }
        public int max { get; set; }
        public int initial { get; set; }
        public int basevalue { get; set; }
        public int currentvalue { get; set; }
        public int threasholdMin { get; set; }
        public int threasholdMax { get; set; }
    }
}
