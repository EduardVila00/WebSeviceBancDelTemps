using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models;
using WebSeviceBancDelTemps.Models.Repositoris;

namespace WebSeviceBancDelTemps.Controllers
{
    public class AdminController : ApiController
    {
        // GET: api/users
        [Route("api/admins")]
        public HttpResponseMessage GetAllAdmins()
        {
            List<Admin> users = AdminRepository.GetAllAdmins();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
        
        [Route("api/admin")]
        public HttpResponseMessage PostUser([FromBody] Admin admin)
        {
            var users = AdminRepository.InsertAdmin(admin);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }

    }
}