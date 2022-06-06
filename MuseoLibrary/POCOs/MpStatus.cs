using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("MpStatus")]
    [PrimaryKey("StatusId")]
    public class MpStatus
    {
        public int StatusId { get; set; }
        public string Name { get; set; }
    }
}