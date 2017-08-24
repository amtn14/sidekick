 using sidekick.Models.Domain;
using sidekick.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sidekick.Services;

namespace sidekick.Controllers.ApiControllers
{
    [RoutePrefix("api/toDo")]
    public class ToDoApiController : ApiController
    {
        [Route("insert"), HttpPost]
        public HttpResponseMessage InsertToDoTask(ToDoRequest model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            int returnedId = ToDoServices.InsertToDoTask(model);
            return Request.CreateResponse(HttpStatusCode.OK, returnedId);
        }

        [Route("getAllTasks"), HttpGet]
        public HttpResponseMessage GetAllTasks()
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            List<toDo> returnedList = ToDoServices.GetAllTasks();
            return Request.CreateResponse(HttpStatusCode.OK, returnedList);
        }
    }
}
