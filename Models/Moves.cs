using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForOleksiyAspNet5.Models
{
    [Table("Hody")]
    public class Moves
    {
        public int Id { get; set; }

        [Column(name: "data_sozdaniya")]
        public DateTime Created { get; set; }

        [Column(name: "igra")]
        public Game Game { get; set; }

        [Column(name: "figura")]
        public string Figure { get; set; } = null!;

        [Column(name: "s")]
        public string From { get; set; } = null!;

        [Column(name: "na")]
        public string To { get; set; } = null!;
    }
}
