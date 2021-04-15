using BookCatalogApriorit.Models;
using BookCatalogApriorit.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogApriorit.Controllers
{
    public class GenreController : Controller
    {
        private GenreService _genreService { set; get; }
        
        public GenreController(GenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Genre> genre = _genreService.GetGenres();
            return Ok(genre);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Genre genre =_genreService.GetGenreById(id);
            return Ok(genre);
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (genre == null)
            {
                return BadRequest();
            }

            _genreService.AddGenre(genre);

            return Ok();
        }

        public void Delete(Genre genre)
        {
            _genreService.DeleteGenre(genre);
        }
        public void Update(Genre genre)
        {
            _genreService.UpdateGenre(genre);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
