﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models.Repositoris;
using System.Data.Entity;
using WebSeviceBancDelTemps.Models;


namespace WebSeviceBancDelTemps.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/users
        [Route("api/users")]
        public HttpResponseMessage GetAllUsers()
        {
            List<User> users = UsersRepository.GetAllUsers();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }

        // GET: api/usersEmail/
        [Route("api/usersEmail/{filtre}")]
        public HttpResponseMessage GetFiltreEmailUsers(string filtre)
        {
            var users = UsersRepository.GetFiltreEmailUsers(filtre);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }

        // GET: api/usersName/
        [Route("api/usersName/{filtre}")]
        public HttpResponseMessage GetFiltreNameLastNameUsers(string filtre)
        {
            var users = UsersRepository.GetFiltreNameLastNameUsers(filtre);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }
        // GET: api/userS/
        [Route("api/userSi/{id}")]
        public HttpResponseMessage GetUser(int id)
        {
            var user = UsersRepository.GetSingleUser(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, user);
            return response;
        }
        
        [Route("api/user")]
        public HttpResponseMessage PostUser([FromBody] User user)
        {
            var users = UsersRepository.InsertUser(user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }

        [Route("api/userLoginPost")]
        public HttpResponseMessage PostLoginUser([FromBody]User user)
        {
            var userSi = UsersRepository.LoginUser(user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userSi);
            return response;
        }
        
        [Route("api/user/{id}")]
        public HttpResponseMessage PutUser(int id, [FromBody]User user)
        {
            var users = UsersRepository.UpdateUser(id, user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
            return response;
        }

        // DELETE: api/user/id
        [Route("api/user/{id?}")]
        public HttpResponseMessage Delete(int id)
        {
            UsersRepository.DeleteUser(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            return response;
        }
    }
}