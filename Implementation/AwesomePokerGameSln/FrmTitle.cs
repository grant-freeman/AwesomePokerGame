using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AwesomePokerGameSln
{
  public partial class FrmTitle : Form {

    public FrmTitle() {
      InitializeComponent();
    }

    private void btnQuit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnViewRuleBook_Click(object sender, EventArgs e) {
      if (btnViewRuleBook.Text.StartsWith("View", true, null)) {
        searchBox.Visible = true;
        searchLabel.Visible = true;
        searchButton.Visible = true;
        searchBackground.Visible = true;
        btnViewRuleBook.Text = "Close Rule Book";
      }
      else {
        searchBackground.Visible = false;
        searchBox.Visible = false;
        searchLabel.Visible = false;
        searchButton.Visible = false;
        btnViewRuleBook.Text = "View Rule Book";
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      if (searchBox.Text.ToLower() == royalFlushImage.Tag.ToString())
      {
        Debug.Print("WE OUTCHEAAAAAAAAAAA");
      }
    }

    private void btnNewGame_Click(object sender, EventArgs e) {
      FrmPlaygame frmPlaygame = new FrmPlaygame();
      frmPlaygame.Show();
      Hide();
    }
    }
}
