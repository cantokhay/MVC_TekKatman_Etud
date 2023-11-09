namespace MvcTekKatman.Entities
{
    public class Class : BaseEntity
    {
        public string ClassName { get; set; }

        public ICollection<User> Users { get; set; }

        public Class()
        {
            Users = new HashSet<User>();
        }
    }
}
