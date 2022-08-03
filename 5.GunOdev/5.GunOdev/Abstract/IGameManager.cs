using System;
using System.Collections.Generic;
using System.Text;
using _5.GunOdev.Entities;

namespace _5.GunOdev.Abstract
{
    public interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game, string name,int price);
    }    
}
