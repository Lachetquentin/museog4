using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("Locations")]
    [PrimaryKey("LocationId")]
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
    }
}
