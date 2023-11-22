using ProtoWayfarer.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoWayfarer.Tools
{
    internal static class SzenarioInitializer
    {
        static Dictionary<string,CardPrototype> d= new Dictionary<string,CardPrototype>();
        public static void startSzenario(string name, CardController cc)
        {

            String basedir = "C:\\Users\\LarsH\\Downloads\\";
            d.Add("Eva",new CardPrototype("Character", "Eva", "Eva is the initial Character in this game", Card.TYPE_CHAR));
            d["Eva"].text = "Eva ist die Protagonistin in unserem Spiel. Sie hat drei Tokens: Körper, Geist, Seele";
            d["Eva"].image = new Bitmap(basedir + "01110-3907089427.jpeg");
            d["Eva"].addTokenField("Körper",6);
            d["Eva"].addTokenField("Geist", 6);
            d["Eva"].addTokenField("Seele", 6);
            d.Add("Shotgun", new CardPrototype("Waffe", "Shotgun", "Eine mächtige Waffe mit mächtigem Badabum. Braucht Aktivierungstokens in Form von Patronen.", Card.TYPE_MAINPOWER));
            d["Shotgun"].addTokenField("Patrone", 2);
            ActivationEffect a=new ActivationEffect();
            a.PotentialTargetList = new string[] { Card.TYPE_ENENMY };
            a.ActivationTokensByAmount = new string[] { "Patrone", "2" };
            Cards.Cardlist cards = new Cards.Cardlist("AllCards");
            foreach (KeyValuePair<string,CardPrototype> cp in d) {
                Card c = new Card(cp.Value);
                cards.Add(c);
            }
            cc.allCards = cards;
            cc.initialDraw();
        }

    }
}
