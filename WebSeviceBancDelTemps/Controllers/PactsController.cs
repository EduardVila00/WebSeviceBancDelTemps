using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models;
using WebSeviceBancDelTemps.Models.Repositoris;

namespace WebSeviceBancDelTemps.Controllers
{
    public class PactsController : ApiController
    {
        // GET: api/posts
        [Route("api/posts")]
        public HttpResponseMessage GetAllPacts()
        {
            List<Pact> posts = PactsRepository.GetAllPacts();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }


        // GET: api/postsDateCreated/
        [Route("api/postsDateCreated/{date:DateTime}")]
        public HttpResponseMessage GetAllPactsPerDateCreatedDespres(DateTime date)
        {
            var posts = PactsRepository.GetAllPactsPerDateCreatedDespres(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // GET: api/postsDateFinished/
        [Route("api/postsDateFinished/{date:DateTime}")]
        public HttpResponseMessage GetAllPactsPerDateCreatedAbans(DateTime date)
        {
            var posts = PactsRepository.GetAllPactsPerDateCreatedAbans(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsDateFinished/
        [Route("api/postsDateFinished/{date:DateTime}")]
        public HttpResponseMessage GetAllPactsPerDateCreatedMateix(DateTime date)
        {
            var posts = PactsRepository.GetAllPactsPerDateCreatedMateix(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        } 
        // GET: api/postsDateCreated/
        [Route("api/postsDateCreated/{date:DateTime}")]
        public HttpResponseMessage GetAllPactsPerDateFinishedDespres(DateTime date)
        {
            var posts = PactsRepository.GetAllPactsPerDateFinishedDespres(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // GET: api/postsDateFinished/
        [Route("api/postsDateFinished/{date:DateTime}")]
        public HttpResponseMessage GetAllPactsPerDateFinishedAbans(DateTime date)
        {
            var posts = PactsRepository.GetAllPactsPerDateFinishedAbans(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsDateFinished/
        [Route("api/postsDateFinished/{date:DateTime}")]
        public HttpResponseMessage GetAllPactsPerDateFinishedMateix(DateTime date)
        {
            var posts = PactsRepository.GetAllPactsPerDateFinishedMateix(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/post/
        [Route("api/post/{id}")]
        public HttpResponseMessage GetSinglePact(int id)
        {
            var post = PactsRepository.GetSinglePact(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, post);
            return response;
        }
        // GET: api/postsLocation/
        [Route("api/postsLocation/{location:alpha}")]
        public HttpResponseMessage GetPactsByLocation(string location)
        {
            var posts = PactsRepository.GetPactsByLocation(location);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsTitle/
        [Route("api/postsTitle/{title:alpha}")]
        public HttpResponseMessage GetPactsByTitle(string title)
        {
            var posts = PactsRepository.GetPactsByTitle(title);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsUser/
        [Route("api/postsUser/{userId:int}")]
        public HttpResponseMessage GetPactsByUser(int userId)
        {
            var posts = PactsRepository.GetPactsByUser(userId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        [Route("api/post")]
        public HttpResponseMessage PactPact([FromBody] Pact post)
        {
            var posts = PactsRepository.InsertPact(post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        [Route("api/post/{id}")]
        public HttpResponseMessage PutPact(int id, [FromBody]Pact post)
        {
            var posts = PactsRepository.UpdatePact(id, post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // DELETE: api/post/id
        [Route("api/post/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            PactsRepository.De(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            return response;
        }
    }
}