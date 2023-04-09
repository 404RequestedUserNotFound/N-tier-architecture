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
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/project")]
        public HttpResponseMessage AllProject()
        {
            try
            {
                var data = ProjectService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/project/{id}")]
        public HttpResponseMessage GetProject(int id)
        {
            try
            {
                var data = ProjectService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Project not found");
            }

        }






        [HttpPost]
        [Route("api/project/add")]
        public HttpResponseMessage AddProject(ProjectDTO project)
        {
            try
            {
                var data = ProjectService.Create(project);
                return Request.CreateResponse(HttpStatusCode.OK, "New Project has been Created");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/project/update")]
        public HttpResponseMessage UpdateProject(ProjectDTO project)
        {
            try
            {
                var data = ProjectService.Update(project);
                return Request.CreateResponse(HttpStatusCode.OK, "Project Details has been updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/project/{id}")]
        public HttpResponseMessage DeleteProject(int id)
        {
            try
            {
                var data = ProjectService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Project has been deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }

        }
    }
}
