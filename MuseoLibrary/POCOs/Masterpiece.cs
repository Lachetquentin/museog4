using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace MuseoLibrary
{
    [TableName("Masterpieces")]
    [PrimaryKey("MasterpieceId")]
    public class Masterpiece
    {
        public int MasterpieceId { get; set; }
        public int ArtistId { get; set; }
        public int ExhibitionId { get; set; }
        public int StateId { get; set; }
        public int StatusId { get; set; }
        public int LocationId { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public int CreateYear { get; set; }
        public string Desc { get; set; }
        public string Memo { get; set; }
        public string URL { get; set; }
        public int Ncda { get; set; }
    }
}
