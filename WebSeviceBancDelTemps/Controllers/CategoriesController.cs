using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models;
using WebSeviceBancDelTemps.Models.Repositoris;

namespace WebSeviceBancDelTemps.Controllers
{
    public class CategoriesController : ApiController
    {
        // GET: api/users
        [Route("api/categories")]
        public HttpResponseMessage GetAllCategories()
        {
            List<Category> categories = CategoriesRepository.GetAllCategories();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, categories);
            return response;
        }
        // GET: api/users
        [Route("api/categoriesString")]
        public HttpResponseMessage GetCategoriesString()
        {
            List<string> categories = CategoriesRepository.GetCategoriesNames();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, categories);
            return response;
        }


        // GET: api/category/
        [Route("api/category/{id}")]
        public HttpResponseMessage GetSingleCategory(int id)
        {
            var category = CategoriesRepository.GetSingleCategory(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, category);
            return response;
        }
        // GET: api/category/
        [Route("api/categoryId/{nom}")]
        public IHttpActionResult GetIdCategoryPerString(string nom)
        {
            var category = CategoriesRepository.GetIdCategoryPerString(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, category);
            return Ok(new
            {
                value = category
            });
        }

        // GET: api/category/
        [Route("api/categoryIdWindows/{nom}")]
        public HttpResponseMessage GetIdCategoryPerStringWindows(string nom)
        {
            var category = CategoriesRepository.GetIdCategoryPerString(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, category);
            return response;
        }

        // GET: api/usersEmail/
        [Route("api/categories/{filtre}")]
        public HttpResponseMessage GetFiltreCategories(string filtre)
        {
            var users = CategoriesRepository.GetFiltreCategories(filtre);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }


        [Route("api/category")]
        public HttpResponseMessage PostPost([FromBody] Category category)
        {
            var categorys = CategoriesRepository.InsertCategory(category);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, categorys);
            return response;
        }

        [Route("api/category/{id}")]
        public HttpResponseMessage PutCategory(int id, [FromBody]Category category)
        {
            var categories = CategoriesRepository.UpdateCategory(id, category);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, categories);
            return response;
        }

        // DELETE: api/category/id
        [Route("api/category/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            CategoriesRepository.DeleteCategory(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            return response;
        }
    }
}