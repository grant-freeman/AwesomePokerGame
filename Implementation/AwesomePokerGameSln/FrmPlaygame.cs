using AwesomePokerGameSln.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardType = System.Tuple<int, int>;

namespace AwesomePokerGameSln {
  public partial class FrmPlaygame : Form {
    private Deck deck;
    private PictureBox[] playerCardPics;
    private PictureBox[] dealerCardPics;
    private Hand playerHand;
    private Hand dealerHand;

    public FrmPlaygame() {
      InitializeComponent();
      playerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
      }
      dealerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
      }
    }

    private void dealCards() {
      deck.shuffleDeck();
      Tuple<int, int>[] cards = new Tuple<int, int>[5];
      int index = 0;
      foreach (PictureBox playerCardPic in playerCardPics) {
        CardType card = deck.nextCard();
        //CardType card = new CardType(index, inde);
        cards[index++] = card;
        playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
      }
      dealerHand = new Hand(cards);
      cards = new CardType[5];
      index = 0;
      foreach (PictureBox dealerCardPic in dealerCardPics) {
        CardType card = deck.nextCard();
        //CardType card = new CardType(index, inde);
        cards[index++] = card;
        dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
      }
      playerHand = new Hand(cards);
      lblHandType.Text = playerHand.getHandType().ToString();
    }

    private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e) {
      foreach (Form f in Application.OpenForms)
        f.Close();
    }

    private void FrmPlaygame_Load(object sender, EventArgs e) {
      deck = new Deck();
      dealCards();
    }

    private void button1_Click(object sender, EventArgs e) {
      dealCards();
    }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
