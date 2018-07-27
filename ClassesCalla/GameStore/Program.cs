using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager store = new GameManager();

            VideoGame game1 = new VideoGame();
            game1.GameTitle = "Halo";
            game1.GameCode = 885370928518;
            game1.Price = 59.98m;

            store.AddGame(game1); //we can pass it game one.

            VideoGame game2 = new VideoGame();
            game2.GameTitle = "Sims";
            game2.GameCode = 14633730371;
            game2.Price = 59.98m;

            store.AddGame(game2);

            store.DisplayGames();
            store.RemoveGame(11);

            store.DisplayGames();
            Console.ReadKey();



        }
    }
}
