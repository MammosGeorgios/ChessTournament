using ChessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    class Program
    {
        static void Main(string[] args)
        {

            Player john = new Player("John", "Grandmaster");
            Player jim = new Player("Jim", "Master");
            Player jake = new Player("Jake", "Master");
            Player jane = new Player("Jane", "Master");

            Game table1 = new Game("Table 1");
            Game table2 = new Game("Table 2");
            Game table3 = new Game("Table 3");

            table1.PlayerJoinsWhite(john);
            table2.PlayerJoinsWhite(john);
            table3.PlayerJoinsWhite(john);

            table1.PlayerJoinsBlack(jim);
            table2.PlayerJoinsBlack(jake);
            table3.PlayerJoinsBlack(jane);

            table1.StartGame(10, 15);
            table2.StartGame(10, 15);
            table3.StartGame(10, 15);

        }
    }
}
