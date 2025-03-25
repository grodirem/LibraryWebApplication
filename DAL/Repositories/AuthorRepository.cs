using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories;

public class AuthorRepository : Repository<Author>, IAuthorRepository
{
    public AuthorRepository(ApplicationContext context) : base(context) { }
}
