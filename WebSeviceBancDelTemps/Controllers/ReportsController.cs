﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebSeviceBancDelTemps.Models;
using WebSeviceBancDelTemps.Models.Repositoris;

namespace WebSeviceBancDelTemps.Controllers
{
    public class ReportsController : ApiController
    {
        // GET: api/reports
        [Route("api/reports")]
        public HttpResponseMessage GetAllReports()
        {
            List<Report> reports = ReportsRepository.GetAllReports();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reports);
            return response;
        }
        // GET: api/reports
        [Route("api/report/{id}")]
        public HttpResponseMessage GetSingleReport(int id)
        {
            Report reports = ReportsRepository.GetSingleReport(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reports);
            return response;
        }
        // GET: api/reports/desc
        [Route("api/reportsDesc/{desc}")]
        public HttpResponseMessage GetAllReportsDesc(string desc)
        {
            List<Report> reports = ReportsRepository.GetAllReportsDesc(desc);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reports);
            return response;
        }
        // GET: api/reports per post
        [Route("api/reportsPost")]
        public HttpResponseMessage GetAllReportsPost([FromBody] Post post)
        {
            List<Report> reports = ReportsRepository.GetAllReportsPerPost(post);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reports);
            return response;
        }
        // GET: api/reports per user
        [Route("api/reportsUser")]
        public HttpResponseMessage GetAllReportsUser([FromBody] User user)
        {
            List<Report> reports = ReportsRepository.GetAllReportsPerUser(user);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reports);
            return response;
        }
        // GET: api/reports per estat
        [Route("api/reportsRevised/{revised:bool}")]
        public HttpResponseMessage GetAllReports(bool revised)
        {
            List<Report> reports = ReportsRepository.GetAllReportsPerRevised(revised);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reports);
            return response;
        }
        // PUT: api/report
        [Route("api/updateReport/{id}")]
        public HttpResponseMessage PutReport(int id, [FromBody]Report report)
        {
            Report reports = ReportsRepository.UpdateReport(id, report);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reports);
            return response;
        }
        // DELETE: api/report
        [Route("api/report/{id}")]
        public HttpResponseMessage DeleteReport(int id)
        {
            ReportsRepository.DeleteReport(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
        // DELETE: api/report
        [Route("api/insertReport/")]
        public IHttpActionResult InsertReport([FromBody]Report report)
        {
            ReportsRepository.InsertReport(report);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Ok(new
            {
                value = response
            });
        }
    }
}