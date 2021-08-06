using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class GenreCounter : IGenreCounter
    {
        public int SciFiCounter { get; set; }
        public int FantasyCounter { get; set; }

        public GenreCounter()
        {

        }

        public void IncrementCounter(string genre, bool approved)
        {
            var a = approved ? (genre == "SciFi" ? SciFiCounter++ : FantasyCounter++) : (genre == "SciFi" ? SciFiCounter-- : FantasyCounter--);
        }
    }
}
