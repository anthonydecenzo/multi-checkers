using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicheckers.Server
{
    /// <summary>
    /// Observes and moderates the entire game. It creates two Player instances
    /// and handles game functions, such as moving player pieces and validates them.
    /// </summary>
    class Game
    {
        private char[,] gameBoard = new char[8, 8];
        


        private Boolean isMoveValid(Int32 row, Int32 column)
        {
            return false;
        }

        public void setPosition(Int32 row, Int32 column, char playerSymbol)
        {
            gameBoard[row, column] = playerSymbol;
        }

        public char[,] Board {
            get { return gameBoard; }
        }

    }
}
