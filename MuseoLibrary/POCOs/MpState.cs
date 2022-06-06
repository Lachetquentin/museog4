using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("MpStates")]
    [PrimaryKey("StateId")]
    public class MpState
    {
        public int StateId { get; set; }
        public string Name { get; set; }
    }
}
