using ChessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Interface
{
    interface IGame
    {

        void PlayMove(string move);
        void PlayerJoinsWhite(Player white);
        void PlayerJoinsBlack(Player black);
        void StartGame(int gameTime,int moveTime);
    }
}
