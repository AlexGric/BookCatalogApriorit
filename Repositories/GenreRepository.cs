using BookCatalogApriorit.Context;
using BookCatalogApriorit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogApriorit.Repositories
{
    public class GenreRepository
    {
        private BookCatalogContext _context;

        public GenreRepository(BookCatalogContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetAllGentes()
        {
            return _context.Genres.ToList();
        }

        public Genre GetGenreById(int id)
        {
            return _context.Genres.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddGenre(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }
        public void DeleteGenre(Genre genre)
        {
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }
        public void UpdateGenre(Genre genre)
        {
            _context.Genres.Update(genre);
            _context.SaveChanges();
        }
    }
}
