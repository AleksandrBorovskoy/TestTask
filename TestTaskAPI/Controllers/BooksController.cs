using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTaskAPI.Data.Repositories;
using TestTaskAPI.Dtos;
using TestTaskAPI.Models;

namespace TestTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bookRepository.GetAll());
        }

        [HttpPost("Add")]
        public IActionResult Create(BookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                YearOfPublication = dto.YearOfPublication,
                Genre = dto.Genre
            };

            return Created("Book is created", _bookRepository.Create(book));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, BookDto dto)
        {
            try
            {
                _bookRepository.Update(id, dto);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            try
            {
                _bookRepository.DeleteById(id);
                return NoContent();
            }
            catch (Exception)
            { 
                return NotFound();
            }

        }
    }
}
