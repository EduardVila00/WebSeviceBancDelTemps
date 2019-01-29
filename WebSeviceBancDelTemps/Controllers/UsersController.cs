using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models.Repositoris;
using System.Data.Entity;


namespace WebSeviceBancDelTemps.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/contactes
        [Route("api/users")]
        public HttpResponseMessage Get()
        {
            var users = UsersRepository.GetAllUsers();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
    }
}