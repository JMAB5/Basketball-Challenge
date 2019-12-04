using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballChallenge.Data.Models
{
    public class Game
    {
        public int ID { get; set; }
        public DateTime DateofGame { get; set; }
        public string Location { get; set; }
        public string UserPaid { get; set; }
        public double AmountPaid { get; set; }
    }
}
