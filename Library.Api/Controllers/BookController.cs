using System;
using Library.Domain.Interfaces;
using Library.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace LB_Api.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IServiceBook _serviceBook;

        public BookController(IServiceBook serviceBook) =>
            _serviceBook = serviceBook;

        [HttpPost]
        public IActionResult Register([FromBody] BookModel bookModel)
        {
            try
            {
                var book = _serviceBook.Insert(bookModel);

                return Ok(book?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                var books = _serviceBook.RecoverAll();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            try
            {
                var book = _serviceBook.RecoverById(id);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] BookModelUpdate bookModel)
        {
            try
            {
                var book = _serviceBook.Update(id, bookModel);

                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] int id)
        {
            try
            {
                _serviceBook.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
