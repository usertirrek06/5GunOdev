using System;
using System.Collections.Generic;
using System.Text;
using _5.GunOdev.Abstract;
using _5.GunOdev.Entities;

namespace _5.GunOdev.Managers
{
    class GameManager : IGameManager
    {
        public List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.gameName+" Added.");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine(game.gameName + " Deleted.");
        }

        public void Update(Game game, string name,int price)
        {
            game.gameName = name;
            game.Price = price;
            Console.WriteLine("Game Name: "+game.gameName+"\n price : "+game.Price);
        }
    } 
}
