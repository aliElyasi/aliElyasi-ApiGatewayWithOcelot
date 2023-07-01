using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Api.Models;
namespace Article.Api.Services
{
    public class ArticleService
    {
        private List<Article.Api.Models.Article> _articles = GetDefaultArticleData();

        private static List<Article.Api.Models.Article> GetDefaultArticleData()
        {

            return new List<Models.Article>(){
                new Models.Article
            {
                Id = 1,
                Title = "First Article",
                WriterId = 1,
                LastUpdate = DateTime.Now
            },
                new Models.Article
                {
                    Id = 2,
                    Title = "Second title",
                    WriterId = 2,
                    LastUpdate = DateTime.Now
                },
                new Models.Article
                {
                    Id = 3,
                    Title = "Third title",
                    WriterId = 3,
                    LastUpdate = DateTime.Now
                }
            };
        }

        
        public List<Models.Article> GetAll()
        {
            return _articles;
        }

        public Models.Article? Get(int id)
        {
            return _articles.FirstOrDefault(x => x.Id == id);
        }

        public int Delete(int id)
        {
            var removed = _articles.SingleOrDefault(x => x.Id == id);

            if (removed != null)
                _articles.Remove(removed);

            return removed?.Id ?? 0;
        }





    }
}
