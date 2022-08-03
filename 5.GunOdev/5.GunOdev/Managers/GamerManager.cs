using _5.GunOdev.Abstract;
using _5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Managers
{
    class GamerManager : BaseGamerManager
    {
        public List<Gamer> gamers = new List<Gamer>();
        IPersonCheckService personChecker;
        public GamerManager(IPersonCheckService personCheckService)
        {
            personChecker = personCheckService;
        }

        public virtual void Add(Gamer gamer)
        {
            if (personChecker.CheckRealPerson(gamer))
            {
                gamers.Add(gamer);
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Please Check Your Infos");
            }
        }

        public virtual void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
            base.Delete(gamer);
        }

        public virtual void Update(Gamer gamer,string name, string lastName,DateTime dateofbirth)
        {
            if (!gamers.Contains(gamer))
            {
                Console.WriteLine("There is no gamer in the system.");
                return;
            }
            gamer.FirstName = name;
            gamer.LastName = lastName;
            gamer.DateOfBirth = dateofbirth;
            base.Update(gamer);
        }
    }
}
