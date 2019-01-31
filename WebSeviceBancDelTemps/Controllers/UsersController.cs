using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models.Repositoris;
using System.Data.Entity;


namespace WebSeviceBancDelTemps.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/users
        [Route("api/users")]
        public HttpResponseMessage GetAllUsers()
        {
            var users = UsersRepository.GetAllUsers();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
        
        // GET: api/usersEmail/
        [Route("api/usersEmail/{name:alpha}")]
        public HttpResponseMessage GetFiltreEmailUsers(string filtre)
        {
            var users = UsersRepository.GetFiltreEmailUsers(filtre);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
        
        // GET: api/usersName/
        [Route("api/usersName/{name:alpha}")]
        public HttpResponseMessage GetFiltreNameLastNameUsers(string filtre)
        {
            var users = UsersRepository.GetFiltreNameLastNameUsers(filtre);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
    }
}