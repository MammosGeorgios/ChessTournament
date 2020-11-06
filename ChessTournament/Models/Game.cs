using ChessTournament.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Game : IGame
    {
        private string _table;
        private Player _whitePlayer;
        private Player _blackPlayer;
        private bool _turn = true; // True means white plays next
        private int _moveTime;
        private int _gameTime;


        public string Table
        {
            get { return _table; }
            set { _table = value; }
        }       
        public Player WhitePlayer
        {
            get { return _whitePlayer; }
            set { _whitePlayer = value; }
        }      
        public Player MyProperty
        {
            get { return _blackPlayer; }
            set { _blackPlayer = value; }
        }
        public bool Turn
        {
            get { return _turn; }
            set { _turn = value; }
        }
        

        public int MoveTime
        {
            get { return _moveTime; }
            set { _moveTime = value; }
        }

       
        public int Gametime
        {
            get { return _gameTime; }
            set { _gameTime = value; }
        }





        public Game (string table)
        {
            _table = table;
            Console.WriteLine($"Table {table} is set up!");
        }




        public void PlayerJoinsBlack(Player black)
        {
            _blackPlayer = black;
            Console.WriteLine($"Player {black.Name} joins {_table} as blacks.");
        }

        public void PlayerJoinsWhite(Player white)
        {
            _whitePlayer = white;
            Console.WriteLine($"Player {white.Name} joins {_table} as whites.");
        }

        public void PlayMove(string move)
        {
            if (_turn == true && _gameTime >0)
            {
                Console.WriteLine($"{ _whitePlayer.Name} plays move {move} against {_blackPlayer.Name}.");
                _turn = false;
                _gameTime -= _moveTime;
            }
            else if (_turn = false && _gameTime >0)
            {
                Console.WriteLine($"{ _blackPlayer.Name} plays move {move} against {_whitePlayer.Name}.");
                _turn = true;
                _gameTime -= _moveTime;

            }
            else
            {
                Console.WriteLine( "OUT OF TIME");
            }
        }

        public void StartGame(int mins, int moveTimeSecs)
        {
            _gameTime = mins * 60;
            _moveTime = moveTimeSecs;
        }
    }
}
