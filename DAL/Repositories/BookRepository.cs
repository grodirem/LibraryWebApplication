using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories;

public class BookRepository : Repository<Book>, IBookRepository
{
    public BookRepository(ApplicationContext context) : base(context) { }

    public async Task<IEnumerable<Book>> GetBooksByAuthorIdAsync(int id)
        => await _context.Books
            .Where(b => b.AuthorId == id)
            .ToListAsync();

    public async Task<Book> GetByISBNAsync(string isbn)
        => await _context.Books
            .FirstOrDefaultAsync(b => b.ISBN == isbn);
}
