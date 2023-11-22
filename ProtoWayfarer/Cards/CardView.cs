using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoWayfarer.Cards
{
    public partial class CardView : UserControl
    {
        public Card MyCard { set; get; }
        public CardView(Card c)
        {
            this.MyCard = c;
            InitializeComponent();
            lblHeadline.Text = c.CardProperties.Name;
            string token = "";
            foreach (KeyValuePair<string, TokenVals> tokenval in c.CardTokenValues)
            {
                token = token + tokenval.Key.Remove(1);
                token = token + tokenval.Value.currentvalue + " | ";
                //+"/";
                //token = token + tokenval.Value.basevalue
            }
            lblTokens.Text = token;
            lblTypValue.Text = c.CardProperties.Type + " (X)";
            if (c.CardProperties.image != null)
            {
                pictureBox1.BackgroundImage = c.CardProperties.image;
            }
            toolTip.SetToolTip(pictureBox1, c.CardProperties.text);
            toolTip.SetToolTip(lblHeadline, c.CardProperties.Description);
        }
        public CardView()
        {
            this.MyCard = null;
            InitializeComponent();
        }
    }
}
