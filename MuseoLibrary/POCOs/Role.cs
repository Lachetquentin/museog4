using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("Roles")]
    [PrimaryKey("RoleId")]
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
}