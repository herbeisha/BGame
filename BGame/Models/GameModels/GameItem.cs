using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGame.Models
{
    public class GameItem
    {
        public string Name { get; set; }
        public int GameItemId { get; set; }
        public string Description { get; set; }
        public DateTime GameTime { get; set; }
        public float Price { get; set; }
        public int Players { get; set; }
        public int UserId { get; set; }
        public int Age { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
