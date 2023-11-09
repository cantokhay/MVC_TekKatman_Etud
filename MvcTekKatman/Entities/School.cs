namespace MvcTekKatman.Entities
{
    public class School : BaseEntity
    {
        public string SchoolName { get; set; }

        public ICollection<User> Users { get; set; }

        public School()
        {
            Users = new HashSet<User>();
        }
    }
}
