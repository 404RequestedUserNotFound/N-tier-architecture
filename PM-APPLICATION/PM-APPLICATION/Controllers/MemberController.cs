using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PM_APPLICATION.Controllers
{
    public class MemberController : ApiController
    {

        [HttpGet]
        [Route("api/member")]
        public HttpResponseMessage AllMember()
        {
            try
            {
                var data = MemberService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/member/{id}")]
        public HttpResponseMessage GetMember(int id)
        {
            try
            {
                var data = MemberService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Member not found");
            }

        }





        [HttpPost]
        [Route("api/member/add")]
        public HttpResponseMessage AddMember(MemberDTO news)
        {
            try
            {
                var data = MemberService.Create(news);
                return Request.CreateResponse(HttpStatusCode.OK, "Member has been added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/member/update")]
        public HttpResponseMessage UpdateMember(MemberDTO news)
        {
            try
            {
                var data = MemberService.Update(news);
                return Request.CreateResponse(HttpStatusCode.OK, "Member information has been updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/member/{id}")]
        public HttpResponseMessage DeleteMember(int id)
        {
            try
            {
                var data = MemberService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Member has been deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
