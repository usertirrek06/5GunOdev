using _5.GunOdev.Abstract;
using _5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Managers
{
    class SaleManager : ISaleManager
    {
        public void Sale(Game game, Offer offer)
        {
            var newPrice =game.Price -  (offer.Discount * 100 / game.Price);
            game.Price = newPrice;
            Console.WriteLine(game.gameName+" Price: "+game.Price);
        }

        public void Sale(Game game)
        {
            Console.WriteLine(game.gameName + " Price: " + game.Price);
        }
    }
}
