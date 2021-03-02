using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Filter;
using WebApplication3.Model;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        [HttpGet]
        [Filter.Authorize]
        public IActionResult GetAll()
        {
            BlogService obj = new BlogService();
            return Ok(obj.GetData());
        }
        [HttpPost]
        [Filter.Authorize]
        public IActionResult Post([FromBody]Blog blog)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Request");
            }
            BlogService obj = new BlogService();
            obj.Create(blog, 1);

            return NoContent();
        }
        [HttpPut]
        [Filter.Authorize]
        public IActionResult Put([FromBody] Blog blog)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Request");
            }
            BlogService obj = new BlogService();
            obj.Update(blog);

            return NoContent();
        }
        [HttpDelete]
        [Filter.Authorize]
        public IActionResult Delete(int blogid)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("Invalid Request");
            }
            BlogService obj = new BlogService();
            obj.Delete(blogid);
            return NoContent();
        }

    }
}