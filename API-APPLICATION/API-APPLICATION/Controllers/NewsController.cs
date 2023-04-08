using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_APPLICATION.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/news")]
        public HttpResponseMessage AllNews()
        {
            try
            {
                var data = NewsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/news/{id}")]
        public HttpResponseMessage GetNews(int id)
        {
            try
            {
                var data = NewsService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "News not found");
            }

        }





        [HttpPost]
        [Route("api/news/add")]
        public HttpResponseMessage AddNews(NewsDTO news)
        {
            try
            {
                var data = NewsService.Create(news);
                return Request.CreateResponse(HttpStatusCode.OK, "News inserted");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/news/update")]
        public HttpResponseMessage UpdateNews(NewsDTO news)
        {
            try
            {
                var data = NewsService.Update(news);
                return Request.CreateResponse(HttpStatusCode.OK, "News updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/news/{id}")]
        public HttpResponseMessage DeleteNews(int id)
        {
            try
            {
                var data = NewsService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "News has been deleted.");
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound,ex.Message);
            }
        }
    }
}
