using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWayfarer.Cards
{
    public class ActivationEffect
    {

        const string T_ALL_TYPES = "Target all Types";
        const string T_ONE_OF_TYPES = "Target one of the defined Types";
        const string T_ALL_CARDS = "Target all Cards";
        const string T_ONE_OF_CARD = "Target one of the defined Cards";
        const string E_RAISE_TOKENS = "Raise Tokens";
        const string E_REDUCE_TOKENS = "Reduce Tokens";
        const string OPTIONAL = "NEXT EFFECT IS OPTIONAL";
        const string ADDITIONAL = "NEXT EFFECT IS ADDITIONAL";
        const string NEEDS_ACTIVATION_TOKENS = "NEEDS ACITVATION TOKENS";
        public string[] PotentialTargetList { get; set; }
        public string[] TokenTypesRaisedByAmount { get; set; }
        public string[] TokenTypesNeededByAmount { get; set; }
        public string[] TokenTypesReducedByAmount { get; set; }
        public string[] ReductionReducedByTokenAmount { get; set; }
        public string[] RaisedReducedByTokenAmount { get; set; }
        public string[] ActivationTokensByAmount { get; set; }

    }
}
