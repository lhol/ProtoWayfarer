using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoWayfarer.Cards;

namespace ProtoWayfarer
{
    public class CardController
    {
        public CardController() { 
            
        }
        public Cardlist allCards { get; set; }
        public Cardlist visibleEnemies { get; set; }
        public Cardlist visibleChars { get; set; }
        public Cardlist visibleEnvs { get; set; }
        public Cardlist visibleItems { get; set; }
        public Cardlist physicalInventory { get; set; }
        public Cardlist mentalInventory { get; set; }
        public MainScreen mainScreen { get; set; }
        public FlowLayoutPanel cardPanel1 { get; set; }

        private List<CardView> cardViews;
        private List<CardView> createViews(Cardlist cards)
        {
            List<CardView> cardViews = new List<CardView>();
            foreach (Card card in cards)
            {
                CardView cv = new CardView(card);
                cardViews.Add(cv);
            }
            return cardViews;
        }
        public void redraw(Card card)
        {

        }
        public void initialDraw()
        {
            cardViews= createViews(allCards);
            foreach (CardView cv in cardViews)
            {
                cardPanel1.Controls.Add(cv);
                cv.Size = new Size(96, 128);
                cv.Show();
                cardPanel1.Refresh();
            }
        }
    }
}
