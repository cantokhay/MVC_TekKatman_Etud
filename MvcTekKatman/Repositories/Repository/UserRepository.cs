using MvcTekKatman.Context;
using MvcTekKatman.Entities;
using MvcTekKatman.Repositories.IRespository;

namespace MvcTekKatman.Repositories.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MvcContext db) : base(db)
        {
        }
    }
}
