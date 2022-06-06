using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("Owners")]
    [PrimaryKey("OwnerId")]
    public class Owner
    {
        public int OwnerId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}