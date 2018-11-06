using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AwesomePokerGameSln
{
  public partial class FrmTitle : Form {

    public List<PictureBox> rulesList = new List<PictureBox>();

    public FrmTitle() {
      InitializeComponent();
      rulesList.Add(royalFlushImage);
      rulesList.Add(straightFlushImage);
      rulesList.Add(fourOfAKindImage);
      rulesList.Add(fullHouseImage);
      rulesList.Add(flushImage);
      rulesList.Add(straightImage);
      rulesList.Add(threeOfAKindImage);
      rulesList.Add(twoPairImage);
      rulesList.Add(onePairImage);
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
        for (int i = 0; i < rulesList.Count; i++)
        {
          rulesList[i].Visible = false;
        }
         btnViewRuleBook.Text = "View Rule Book";
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      string[] searchTextSplit = searchBox.Text.Split(' ');
      for (int i = 0; i < rulesList.Count; i++)
      {
        rulesList[i].Visible = false;
        for (int j = 0; j < searchTextSplit.Length; j++)
        {
          if (rulesList[i].Tag.ToString().Contains(searchTextSplit[j]))
          {
            Debug.Print(rulesList[i].Name);
            rulesList[i].Visible = true;
            rulesList[i].BringToFront();
          }
        }
      }
    }

    private void btnNewGame_Click(object sender, EventArgs e) {
      FrmPlaygame frmPlaygame = new FrmPlaygame();
      frmPlaygame.Show();
      Hide();
    }

    private void btnSendFeedback_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://goo.gl/forms/4qiqBnG5B6yDGFsn2");
    }
    }
}
