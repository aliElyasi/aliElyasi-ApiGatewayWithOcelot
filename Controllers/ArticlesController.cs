using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private ArticleService _ArticleService;

        public ArticlesController(ArticleService articleService)
        {
            _ArticleService = articleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ArticleService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var article = _ArticleService.Get(id);

            if (article is null)
                return NotFound();

            return Ok(article);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedId = _ArticleService.Delete(id);

            if (deletedId == 0)
                return NotFound();

            return NoContent();
        }


    }
}