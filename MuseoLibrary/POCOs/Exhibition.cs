using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("Exhibitions")]
    [PrimaryKey("ExhibitionId")]
    public class Exhibition
    {
        public int ExhibitionId { get; set; }
        public string Name { get; set; }
    }
}