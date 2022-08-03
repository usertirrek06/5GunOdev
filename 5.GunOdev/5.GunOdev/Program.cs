using System;
using _5.GunOdev.Abstract;
using _5.GunOdev.Entities;
using _5.GunOdev.Managers;

namespace _5.GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Tarık";
            gamer1.LastName = "ABCD";
            gamer1.NationalatyId = "1234567";
            gamer1.DateOfBirth = new DateTime(1998, 02, 23);

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Ayşe";
            gamer2.LastName = "OAwre";
            gamer2.NationalatyId = "1239877";
            gamer2.DateOfBirth = new DateTime(1948, 06, 11);


            GamerManager gamerManager = new GamerManager(new RealPersonCheckManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer2, "Bugra", "Abcd", DateTime.Now);

            Game game1 = new Game() { gameName = "Cod", Price = 100, GameId = 9 };
            Offer offer1 = new Offer() { Name = "GonlumdenKoptu", Discount = 20, Id = 8 };
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game1,offer1);
        }
    }
}
