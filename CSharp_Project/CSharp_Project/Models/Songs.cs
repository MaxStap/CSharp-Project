using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharp_Project.Models
{
    
    public class Songs
    {
       public List<Song> songs { get; set; }
    }

    public class Song
    {
        public string id { get; set; }
        public string artist { get; set; }
        public string song { get; set; }
        public string duration { get; set; }
        public string category { get; set; }
        public string year { get; set; }

    }

}