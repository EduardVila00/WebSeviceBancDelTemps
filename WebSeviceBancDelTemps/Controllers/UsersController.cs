using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebSeviceBancDelTemps.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/contactes
        [Route("api/users")]
        public HttpResponseMessage Get()
        {
            var contactes = ContactesRepository.GetAllContactes();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactes);
            return response;
        }
    }
}