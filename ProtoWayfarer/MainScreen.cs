using ProtoWayfarer.Cards;
using ProtoWayfarer.Tools;

namespace ProtoWayfarer
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            CardController cardController = new CardController();
            CardPrototype.CardController = cardController;
            cardController.mainScreen = this;
            cardController.cardPanel1 = this.flpCardPanelTest;
            SzenarioInitializer.startSzenario("InitialTestSzenario", cardController);
            cardController.initialDraw();


        }
    }
}