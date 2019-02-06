using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models.Repositoris;
using System.Data.Entity;
using WebSeviceBancDelTemps.Models;


namespace WebSeviceBancDelTemps.Controllers
{
    public class PostsController : ApiController
    {
        // GET: api/posts
        [Route("api/posts")]
        public HttpResponseMessage GetAllPosts()
        {
            List<Post> posts = PostsRepository.GetAllPosts();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // GET: api/postsCategory/
        [Route("api/postsCategory/{idCategory:int}")]
        public HttpResponseMessage GetPostsByCategory(int idCategory)
        {
            var posts = PostsRepository.GetPostsByCategory(idCategory);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // GET: api/postsDateCreated/
        [Route("api/postsDateCreated/{date:DateTime}")]
        public HttpResponseMessage GetPostsByDateCreated(DateTime date)
        {
            var posts = PostsRepository.GetPostsByDateCreated(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // GET: api/postsDateFinished/
        [Route("api/postsDateFinished/{date:DateTime}")]
        public HttpResponseMessage GetPostsByDateFinished(DateTime date)
        {
            var posts = PostsRepository.GetPostsByDateFinished(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsName/
        [Route("api/user/{id}")]
        public HttpResponseMessage GetSinglePost(int id)
        {
            var user = PostsRepository.GetSinglePost(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, user);
            return response;
        }
        // GET: api/postsLocation/
        [Route("api/postsLocation/{location:alpha}")]
        public HttpResponseMessage GetPostsByLocation(string location)
        {
            var posts = PostsRepository.GetPostsByLocation(location);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsTitle/
        [Route("api/postsTitle/{title:alpha}")]
        public HttpResponseMessage GetPostsByTitle(string title)
        {
            var posts = PostsRepository.GetPostsByLocation(title);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsUser/
        [Route("api/postsUser/{userId:int}")]
        public HttpResponseMessage GetPostsByUser(int userId)
        {
            var posts = PostsRepository.GetPostsByUser(userId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        [Route("api/user")]
        public HttpResponseMessage PostPost([FromBody] Post user)
        {
            var posts = PostsRepository.InsertPost(user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        [Route("api/user/{id}")]
        public HttpResponseMessage PutPost(int id, [FromBody]Post post)
        {
            var posts = PostsRepository.UpdatePost(id, post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // DELETE: api/user/id
        [Route("api/user/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            PostsRepository.DeletePost(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            return response;
        }
    }
}