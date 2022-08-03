using _5.GunOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Text;


namespace _5.GunOdev.Entities
{
    public class Game:IEntity
    {
        public int GameId { get; set; }
        public string gameName { get; set; }
        public int Price { get; set; }
    }
}
