using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomePokerGameSln
{
    public partial class Interactions_Window : Form
    {
        public Interactions_Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fiddle Fiddle = new Fiddle();
            Fiddle.Show();
            Fiddle.BackColor = this.BackColor;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Emote_Options Emote_Options = new Emote_Options();
            Emote_Options.Show();
            Emote_Options.BackColor = this.BackColor;
        }
    }
}
