using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Player
    {
        private string _name;
        private string _rank;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }       

       
        public string Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        public Player(string name, string rank)
        {
            _rank = rank;
            _name = name;
            Console.WriteLine($"{name} ({rank}) joins the tournamen!");
        }



    }
}
