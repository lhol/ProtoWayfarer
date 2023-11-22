using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWayfarer.Cards
{
    public class Card
    {
        public Card(CardPrototype cp) {
            this.CardProperties = cp;
            cp.numberOfCardsInstantiated=cp.numberOfCardsInstantiated+1;
            this.Id=cp.Id+"."+cp.numberOfCardsInstantiated;
            CardTokenValues = new Dictionary<string, TokenVals>();
            TokenVals activationsPerRound = new TokenVals(0,cp.maxNumberOfActivationsPerRound,0,0,0,0,999);
            CardTokenValues.Add(ACT_PER_ROUND, activationsPerRound);
            if (cp.CardTokens != null)
            {
                foreach (var token in cp.CardTokens)
                {
                    CardTokenValues.Add(token.Key, new TokenVals(0,token.Value,0,0,0,0,999));
                }
            }
        }
        public CardPrototype CardProperties { get; }
        public string Id { get; }
        public Dictionary<string, TokenVals> CardTokenValues { get; private set; }
        // With the following it would be possible to generate cards with different flavour headline/image/text despite being the same cardprototypes...
        // if activating, data should come from prototype if local variable=null;
        //public Image image { get; set; }
        //public string headline { get; set; }
        //public string text { get; set; }
        public static string ACT_PER_ROUND = "ActivationsPerRound";
        public static string ACT_TOKEN = "ActivationTokens";
        public static string TYPE_CHAR = "C";
        public static string TYPE_ITEM = "I";
        public static string TYPE_DECKPOWER = "D";
        public static string TYPE_MAINPOWER = "M";
        public static string TYPE_RULES = "R";
        public static string TYPE_ENENMY = "E";
        public void PropertyChanged()
        {
            CardPrototype.CardController.redraw(this);
        }
        public void EndOfRound()
        {
            CardTokenValues[ACT_PER_ROUND].currentvalue = 0;
        }
        public bool Activate()
        {
            if (CardTokenValues[ACT_PER_ROUND].currentvalue < CardTokenValues[ACT_PER_ROUND].max)
            {
                if (CardTokenValues.ContainsKey(ACT_TOKEN))
                {
                    if (CardTokenValues[ACT_TOKEN].currentvalue >= CardTokenValues[ACT_TOKEN].basevalue)
                    {
                        CardTokenValues[ACT_TOKEN].currentvalue = CardTokenValues[ACT_TOKEN].currentvalue - CardTokenValues[ACT_TOKEN].basevalue;
                    }
                    else
                    {
                        Console.WriteLine("Nicht genug ActivationTokens für die Aktivierung der Karte");
                        return false;
                    }
                }
                CardTokenValues[ACT_PER_ROUND].currentvalue = CardTokenValues[ACT_PER_ROUND].currentvalue + 1;
                return true;
            } else
            {
                Console.WriteLine("Keine Aktivierung in dieser Runde mehr möglich");
                return false;
            }
        }
        public void RaiseTokenValue(string key, int amount )
        {
            if (CardTokenValues.ContainsKey(key))
            {
                TokenVals v = CardTokenValues[key];
                if (v.currentvalue + amount > v.threasholdMax)
                {
                    System.Console.WriteLine("The amount could not be raised wihtout hitting the Threshold. MAXIMUM THRESHOLD TRIGGERED.");
                }
                if (v.currentvalue + amount > v.max)
                {
                    v.currentvalue = v.max;
                    System.Console.WriteLine("The amount could not be raised wihtout hitting the maximum Value. Set to maximum Value.");
                }
                else
                {
                    v.currentvalue = v.currentvalue + amount;
                }
            }
            else
            {
                System.Console.WriteLine("The Tokenkey" + key + "is not existant in this Card while trying to raise");
            }

        }
        public void ReduceTokenValue(string key, int amount)
        {
            if (CardTokenValues.ContainsKey(key))
            {
                TokenVals v = CardTokenValues[key];
                if (v.currentvalue - amount < v.threasholdMin)
                {
                    System.Console.WriteLine("The amount could not be reduced wihtout hitting min Threshold. MINIMUM THRESHOLD TRIGGERED.");
                }
                if (v.currentvalue - amount < v.min)
                {
                    v.currentvalue = v.min;
                    System.Console.WriteLine("The amount could not be reduced wihtout minumim Value. Set to minimum Value.");
                } else
                {
                    v.currentvalue = v.currentvalue - amount;
                } 
            }
            else
            {
                System.Console.WriteLine("The Tokenkey" + key + "is not existant in this Card while trying to reduce");
            }

        }
        public void SetTokenValue(string key, TokenVals values)
        {
            if (CardTokenValues.ContainsKey(key))
            {
                CardTokenValues[key] = values;
            } else
            {
                System.Console.WriteLine("The Tokenkey" + key + "is not existant in this Card");
            }
        }
        
    }
}
