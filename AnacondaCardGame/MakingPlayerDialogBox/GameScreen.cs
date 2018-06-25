using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakingPlayerDialogBox
{
    public partial class GameScreen : Form
    {
        public GameScreen(string StrText)
        {
            InitializeComponent();
            playerLabel.Text = StrText;
            
        }
       
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rules rule = new Rules();
            rule.Show();
        }

        private void handRanksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hand_Rankings handRanks = new Hand_Rankings();
            handRanks.Show();

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            
        }

       
    }
}
