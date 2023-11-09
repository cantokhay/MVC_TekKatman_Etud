using MvcTekKatman.Enums;

namespace MvcTekKatman.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        public ICollection<School> Schools { get; set; }

        public ICollection<Class> Classes { get; set; }

        public User()
        {
            Schools = new HashSet<School>();
            Classes = new HashSet<Class>();
        }
    }
}
