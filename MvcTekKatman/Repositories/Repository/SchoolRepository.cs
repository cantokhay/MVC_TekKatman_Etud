using MvcTekKatman.Context;
using MvcTekKatman.Entities;
using MvcTekKatman.Repositories.IRespository;

namespace MvcTekKatman.Repositories.Repository
{
    public class SchoolRepository : BaseRepository<School>, ISchoolRepository
    {
        public SchoolRepository(MvcContext db) : base(db)
        {
        }
    }
}
