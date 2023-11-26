using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTaskAPI.Data.Repositories;
using TestTaskAPI.Dtos;
using TestTaskAPI.Models;

namespace TestTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_authorRepository.GetAll());
        }

        [HttpPost("Add")]
        public IActionResult Create(AuthorDto dto)
        {
            var author = new Author
            {
                Name = dto.Name,
                Surname = dto.Surname,
                BirthDate = dto.BirthDate
            };

            return Created("Author is created", _authorRepository.Create(author));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AuthorDto dto)
        {
            try
            {
                _authorRepository.Update(id, dto);
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
                _authorRepository.DeleteById(id);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
