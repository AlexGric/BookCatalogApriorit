using BookCatalogApriorit.Models;
using BookCatalogApriorit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogApriorit.Services
{
    public class GenreService
    {
        private GenreRepository _repository { get; set; }

        public GenreService(GenreRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _repository.GetAllGentes();
        }

        public Genre GetGenreById(int id)
        {
            return _repository.GetGenreById(id);
        }

        public void AddGenre(Genre genre)
        {
            _repository.AddGenre(genre);
        }

        public void DeleteGenre(Genre genre)
        {
            _repository.DeleteGenre(genre);
        }

        public void UpdateGenre(Genre genre)
        {
            _repository.UpdateGenre(genre);
        }
    }
}
