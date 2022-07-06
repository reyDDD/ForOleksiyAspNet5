using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOleksiyAspNet5.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTimeOffset StatrtGame { get; set; }
        public DateTimeOffset EndGame { get; set; }
        public Gamer GamerWhite { get; set; } = new();
        public Gamer GamerDark { get; set; } = new();

    }
}
