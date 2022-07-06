using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForOleksiyAspNet5.Models
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public Rang Rang { get; set; }

    }

    public enum Rang
    {
        Candidate = 0,
        Master = 1
    }
}
