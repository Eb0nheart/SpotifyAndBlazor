using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyTest.Models
{
    public class SearchResult
    {
        public Albums Albums { get; set; }
    }

    public class Albums
    {
        public IEnumerable<Item> Items { get; set; }
    }
}
