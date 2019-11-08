using BLL.DTO;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Security;

namespace API.Controllers
{
    [RoutePrefix("api/Book")]
    public class BookController : ApiController
    {
        private IBookService service;
       
        public BookController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("")]
       
        public IHttpActionResult GetBooks()
        {
            var posts = service.GetBooks();
            return Ok(posts);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeleteBook(int id)
        {
            service.Delete(id);
            return Ok();
        }
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetBook(int id)
        {
            var productdto = service.GetBook(id);
           // var productView = Mapper.Map<ProductDTO, ProductViewModel>(productdto);
            return Ok(productdto);
        }
        [HttpPost]
        [Route("")]

        public IHttpActionResult PostBook(BookDTO product)
        {
            if (ModelState.IsValid)
            {
                service.Add(product);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPut]
        [Route("UpdateBook/{id:int}")]
        public IHttpActionResult PutBook(int id, BookDTO product)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, product);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}