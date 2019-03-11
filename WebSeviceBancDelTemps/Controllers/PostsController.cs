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
        [Route("api/postsDateCreated/{date}")]
        public HttpResponseMessage GetPostsByDateCreated(string date)
        {
            var posts = PostsRepository.GetPostsByDateCreated(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // GET: api/postsDateFinished/
        [Route("api/postsDateFinished/{date}")]
        public HttpResponseMessage GetPostsByDateFinished(string date)
        {
            var posts = PostsRepository.GetPostsByDateFinished(date);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/post/
        [Route("api/post/{id}")]
        public HttpResponseMessage GetSinglePost(int id)
        {
            var post = PostsRepository.GetSinglePost(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, post);
            return response;
        }
        // GET: api/postsLocation/
        [Route("api/postsLocation/{location}")]
        public HttpResponseMessage GetPostsByLocation(string location)
        {
            var posts = PostsRepository.GetPostsByLocation(location);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsTitle/
        [Route("api/postsTitle/{title}")]
        public HttpResponseMessage GetPostsByTitle(string title)
        {
            var posts = PostsRepository.GetPostsByTitle(title);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        // GET: api/postsUser/
        [Route("api/postsUser/{filtre}")]
        public HttpResponseMessage GetPostsByUser(string filtre)
        {
            var posts = PostsRepository.GetPostsByUser(filtre);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }
        [Route("api/post")]
        public HttpResponseMessage PostPost([FromBody] Post post)
        {
            var posts = PostsRepository.InsertPost(post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        [Route("api/post/{id}")]
        public HttpResponseMessage PutPost(int id, [FromBody]Post post)
        {
            var posts = PostsRepository.UpdatePost(id, post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, posts);
            return response;
        }

        // DELETE: api/post/id
        [Route("api/post/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            PostsRepository.DeletePost(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            return response;
        }
    }
}