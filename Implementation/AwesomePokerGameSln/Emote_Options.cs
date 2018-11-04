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
    public partial class Emote_Options : Form
    {
        public Emote_Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DabOnHaters DabOnHaters = new DabOnHaters();
            DabOnHaters.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flexing Flexing = new Flexing();
            Flexing.Show();
        }
    }
}
