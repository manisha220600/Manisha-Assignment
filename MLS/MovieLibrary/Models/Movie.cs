using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Models
{
    public class Movie
    {
        //MovieId,MovieName,Lang,ReleaseDate,Actor,Director
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Lang { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
    }
}
