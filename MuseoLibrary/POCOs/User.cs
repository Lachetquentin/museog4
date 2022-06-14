using NPoco;

namespace MuseoLibrary
{
    [TableName("Users")]
    [PrimaryKey("UserId")]
    public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
