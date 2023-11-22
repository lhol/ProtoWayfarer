using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWayfarer.Cards
{
    public class CardPrototype
    {
        public CardPrototype(string id, string name, string descripton, string type)
        {
            maxNumberInInventory = 999;
            maxNumberInDeck = 999;
            maxNumberInDecks = 999;
            maxNumberInGame = 999;
            maxNumberActiveInGame = 999;
            maxNumberOfActivationsPerRound = 1;
            numberOfCardsInstantiated = 0;
            AmountOfActivationTokenNeeded = 0;

            this.Id = id;
            this.Name = name;
            this.Description = descripton;
            this.Type = type;
        }
        public void addTokenField(string tokenName, int maxValue)
        {
            if (CardTokens == null)
            {
                CardTokens = new Dictionary<string, int>();
            }
            CardTokens.Add(tokenName, maxValue);
        }
        public string Id { get; }
        
        public string Name { get; }
        public string Description { get; }
        public string Type { get; }
        public Image image { get; set; }
        public string headline { get; set; }
        public string text { get; set; }
        public int maxNumberInDeck { get; set; }
        public int maxNumberInDecks { get; set; }
        public int maxNumberInGame { get; set; }
        public int maxNumberActiveInGame { get; set; }
        public int maxNumberInInventory { get; set; }
        public int numberOfCardsInstantiated { get; set; }
        public int maxNumberOfActivationsPerRound { get; set; }
        public int AmountOfActivationTokenNeeded { get; set; }
        public Dictionary<string, int> CardTokens { get; private set; }
        public ActivationEffect[] ActivationEffect { get; set; }
        public static CardController CardController { get; set; }
    }
}
