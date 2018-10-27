using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicheckers.Server
{
    class Player
    {

        public enum Color { RED, BLACK };

        private int[] selectedPiece = null;
        private string playerName = null;

        private Color playerColor;

        public Player(string playerName, Color playerColor)
        {
            selectedPiece = new int[2];
            this.playerName = playerName;
            this.playerColor = playerColor;
        }

        // each time a player selects a new piece this method is called
        // note: develop a way to prevent a user from selecting the opponent's piece
        public void setSelectedPiece(int row, int column)
        {
            selectedPiece[0] = row;
            selectedPiece[1] = column;
        }

        public int[] SelectedPiece
        {
            get { return selectedPiece;  }
        }
    }
}
