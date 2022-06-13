using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("Artists")]
    [PrimaryKey("ArtistId")]
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Desc { get; set; }
        public string URL { get; set; }
        public string Isni { get; set; }
    }
}
