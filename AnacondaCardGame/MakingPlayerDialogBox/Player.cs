using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingPlayerDialogBox
{
    class Player
    {


        string _name;
        int _wins;
        int _losses;

        public Player()
        {
            _name = "";
            _wins = 0;
            _losses = 0;
        }

        public Player(string name, int wins, int losses)
        {
            _name = name;
            _wins = wins;
            _losses = losses;
        }

        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }
        }

        public int Losses
        {
            get { return _losses; }
            set { _losses = value; }
        }

       

        
    }
}
