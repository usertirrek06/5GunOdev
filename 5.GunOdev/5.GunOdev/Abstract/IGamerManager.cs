using System;
using System.Collections.Generic;
using System.Text;
using _5.GunOdev.Entities;
namespace _5.GunOdev.Abstract
{
    public interface IGamerManager
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
