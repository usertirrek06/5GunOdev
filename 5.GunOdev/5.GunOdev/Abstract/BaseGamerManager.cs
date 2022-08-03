using _5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Abstract
{
    public abstract class BaseGamerManager : IGamerManager
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer Added. " +gamer.FirstName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted. " + gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated.");
        }
    }
}
