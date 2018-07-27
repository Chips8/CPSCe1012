using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//we use the name Manager to manage the game list/array qualities
namespace GameStore
{
    class GameManager
    {
        //our list has to be protected so we are no longer going to create it in the main
        //we are going to make a public list and creating a property...
        public List<VideoGame> GameList { get; set; }

        //now lets create the constructor
        public GameManager()
        {
            GameList = new List<VideoGame>(); //it doesn't get created/initialized as soon as it is launched, only when it gets to this point
        }
        //one thing only in these methods
        public void AddGame(VideoGame currentGame) //videoGame is the datatype
        {
            GameList.Add(currentGame);
        }
        public void DisplayGames()
        {
            //format it nicely
            Console.WriteLine($"{"Game Code",-15}{" ",-5}{"Game Title",-20}{" " ,-5}{"Price",-10}");
            foreach (var item in GameList)
            {
                Console.WriteLine($"{item.GameCode,-15}{" ",-5}{item.GameTitle,-20}{" ",-5}{item.Price,-10:C2}");
            }
        }
        public bool RemoveGame(long code)
        {
            //we will display a boolean to tell us if we were successful
            bool gameRemoved = false;

            //lets go create another method that tries to find the game first, to see if it even exists.
            VideoGame game = FindOneGame(code);
            if (game!=null)
            {
                GameList.Remove(game);
                gameRemoved = true;
            }
            return gameRemoved;
        }
        public VideoGame FindOneGame(long code)
        {
            //we need to have a video game object to return
            VideoGame gameFound = null;

            for (int i = 0; i < GameList.Count; i++)
            {
                if (GameList[i].GameCode==code)
                {
                    gameFound = GameList[i]; //if we find the game then
                }
            }
            return gameFound;
        }

    }
}
