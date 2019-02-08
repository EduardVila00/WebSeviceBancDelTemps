using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models;
using WebSeviceBancDelTemps.Models.Repositoris;

namespace WebSeviceBancDelTemps.Controllers
{
    public class BansController : ApiController
    {
        // GET: api/bans
        [Route("api/bans")]
        public HttpResponseMessage GetAllBans()
        {
            List<Ban> bans = BansRepository.GetAllBans();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, bans);
            return response;
        }


        // GET: api/ban/
        [Route("api/ban/{id}")]
        public HttpResponseMessage GetUser(int id)
        {
            var user = BansRepository.GetSingleBan(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, user);
            return response;
        }

        [Route("api/ban")]
        public HttpResponseMessage PostUser([FromBody] Ban user)
        {
            var bans = BansRepository.InsertBan(user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, bans);
            return response;
        }

        [Route("api/ban/{id}")]
        public HttpResponseMessage PutUser(int id, [FromBody]Ban user)
        {
            var bans = BansRepository.UpdateBan(id, user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, bans);
            return response;
        }

        // DELETE: api/ban/id
        [Route("api/ban/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            BansRepository.DeleteBan(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            return response;
        }
    }
}