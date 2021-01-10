using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyTest.Models
{
    public class Item
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public IList<Image> Images { get; set; }
    }

    public class Image
    {
        public string Url { get; set; }
    }
}
