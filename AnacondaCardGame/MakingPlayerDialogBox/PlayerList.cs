using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MakingPlayerDialogBox
{
    struct PlayerPicker
    {
        public string name;
        public int Win;
        public int Loss;
    }

    public partial class PlayerList : Form
    {
        public PlayerList()
        {
            InitializeComponent();
        }

        private List<PlayerPicker> players =
            new List<PlayerPicker>();



        

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;
                string line;

                PlayerPicker play = new PlayerPicker();

                char[] delim = { ',' };

                inputFile = File.OpenText("Players.csv");

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    play.name = tokens[0];
                    play.Win = Convert.ToInt32(tokens[1]);
                    play.Loss = Convert.ToInt32(tokens[2]);

                    players.Add(play);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayNames()
        {
            foreach (PlayerPicker play in players)
            {
                listBox1.Items.Add(play.name);
            }
        }

        private void PlayerList_Load(object sender, EventArgs e)
        {
            ReadFile();

            DisplayNames();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                

                string player = textBox1.Text;
                StreamWriter sw = new StreamWriter("Players.csv", true);
                sw.WriteLine("{0},{1},{2}", player);
                sw.Close();

                GameScreen GS = new GameScreen(player);
                GS.ShowDialog();
                

            }
        }

        

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listBox1.SelectedIndex;

            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                GameScreen GS = new GameScreen(players[i].name);
                GS.ShowDialog();
                
            }
        }

       

        
    }
}
