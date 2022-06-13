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