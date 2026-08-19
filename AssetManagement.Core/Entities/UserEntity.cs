namespace AssetManagement.Core.Entities
{
    public class UserEntity
    {
        public Guid Id { get; private set; }
        public String Username { get; private set; } = null!;
        public String Firstname { get; private set; } = null!;
        public String Lastname { get; private set; } = null!;
    }
}
