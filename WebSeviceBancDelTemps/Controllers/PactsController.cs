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
        // GET: api/pacts
        [Route("api/pacts")]
        public HttpResponseMessage GetAllPacts()
        {
            List<Pact> pacts = PactsRepository.GetAllPacts();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }
        // GET: api/pacts
        [Route("api/pactsAnd")]
        public HttpResponseMessage GetAllPactsAnd()
        {
            var pacts = PactsRepository.GetAllPactsAnd();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }
        // GET: api/pacts
        [Route("api/pactsAnd/{id}")]
        public HttpResponseMessage GetAllPactsIdAnd(int id)
        {
            var pacts = PactsRepository.GetPactsIdAnd(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }



        //// GET: api/pactsDateCreated/
        //[Route("api/pactsDateCreated/{date:DateTime}")]
        //public HttpResponseMessage GetAllPactsPerDateCreatedDespres(DateTime date)
        //{
        //    var pacts = PactsRepository.GetAllPactsPerDateCreatedDespres(date);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
        //    return response;
        //}

        //// GET: api/pactsDateFinished/
        //[Route("api/pactsDateFinished/{date:DateTime}")]
        //public HttpResponseMessage GetAllPactsPerDateCreatedAbans(DateTime date)
        //{
        //    var pacts = PactsRepository.GetAllPactsPerDateCreatedAbans(date);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
        //    return response;
        //}
        //// GET: api/pactsDateFinished/
        //[Route("api/pactsDateFinished/{date:DateTime}")]
        //public HttpResponseMessage GetAllPactsPerDateCreatedMateix(DateTime date)
        //{
        //    var pacts = PactsRepository.GetAllPactsPerDateCreatedMateix(date);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
        //    return response;
        //} 
        //// GET: api/pactsDateCreated/
        //[Route("api/pactsDateCreated/{date:DateTime}")]
        //public HttpResponseMessage GetAllPactsPerDateFinishedDespres(DateTime date)
        //{
        //    var pacts = PactsRepository.GetAllPactsPerDateFinishedDespres(date);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
        //    return response;
        //}

        //// GET: api/pactsDateFinished/
        //[Route("api/pactsDateFinished/{date:DateTime}")]
        //public HttpResponseMessage GetAllPactsPerDateFinishedAbans(DateTime date)
        //{
        //    var pacts = PactsRepository.GetAllPactsPerDateFinishedAbans(date);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
        //    return response;
        //}
        //// GET: api/pactsDateFinished/
        //[Route("api/pactsDateFinished/{date:DateTime}")]
        //public HttpResponseMessage GetAllPactsPerDateFinishedMateix(DateTime date)
        //{
        //    var pacts = PactsRepository.GetAllPactsPerDateFinishedMateix(date);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
        //    return response;
        //}
        // GET: api/post/
        [Route("api/pact/{id}")]
        public HttpResponseMessage GetSinglePact(int id)
        {
            var post = PactsRepository.GetSinglePact(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, post);
            return response;
        }
        // GET: api/pactsLocation/
        [Route("api/pactsDesc/{desc}")]
        public HttpResponseMessage GetPactsByLocation(string desc)
        {
            var pacts = PactsRepository.GetAllPactsPerDesc(desc);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }
        // GET: api/pactsTitle/
        [Route("api/pactsTitle/{title}")]
        public HttpResponseMessage GetPactsByTitle(string title)
        {
            var pacts = PactsRepository.GetAllPactsPerTitle(title);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }

        // GET: api/postsDateCreated/
        [Route("api/pactsDateCreated/{date}")]
        public HttpResponseMessage GetPostsByDateCreated(string date)
        {
            var posts = PactsRepository.GetAllPactsPerDateCreatedMateix(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsDateCreated/
        [Route("api/pactsDateFinished/{date}")]
        public HttpResponseMessage GetPostsByDateFinished(string date)
        {
            var posts = PactsRepository.GetAllPactsPerDateFinishedMateix(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }


        // GET: api/pactsUser/
        [Route("api/pactsUser/{userId:int}")]
        public HttpResponseMessage GetPactsByUser(int userId)
        {
            var pacts = PactsRepository.GetPactsByUserId(userId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }
        [Route("api/insertPact")]
        public HttpResponseMessage PactPact([FromBody] Pact post)
        {
            var pacts = PactsRepository.InsertPact(post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }

        [Route("api/UpdatePact/{id}")]
        public HttpResponseMessage PutPact(int id, [FromBody]Pact post)
        {
            var pacts = PactsRepository.UpdatePact(id, post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, pacts);
            return response;
        }

        // DELETE: api/post/id
        [Route("api/deletePact/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            PactsRepository.DeletePact(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            return response;
        }
    }
}