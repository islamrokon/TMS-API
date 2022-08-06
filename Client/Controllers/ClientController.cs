using BLL.Entity;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Client.Auth;

namespace Client.Controllers
{
    [ClientAuth]
    public class ClientController : ApiController
    {
        [Route("api/client/home")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var d = ClientService.Get();
            if (d != null)
                return Request.CreateResponse(HttpStatusCode.OK, d);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
        }
        [Route("api/client/home/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var d = ClientService.Get(id);
            if (d != null)
                return Request.CreateResponse(HttpStatusCode.OK, d);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
        }
        [Route("api/client/update")]
        [HttpGet]
        public HttpResponseMessage EditProfile(ClientModel user)
        {
            if (ClientService.Edit(user))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Profile Edited Successfully");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Profile Edit Failed");
        }
        [Route("api/client/add")]
        [HttpGet]
        public HttpResponseMessage AddUser(ClientModel c)
        {
            if (ClientService.Create(c))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Added");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Try again!");
        }
        /*[Route("api/client/getpackage")]
        [HttpGet]
        public HttpResponseMessage GetPackage()
        {
            var d = ClientService.GetPackage();
            if (d != null)
                return Request.CreateResponse(HttpStatusCode.OK, d);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
        }*/
        [Route("api/client/getpackage/{id}")]
        [HttpGet]
        public HttpResponseMessage GetPackage(int id)
        {
            var d = ClientService.GetPackage(id);
            if (d != null)
                return Request.CreateResponse(HttpStatusCode.OK, d);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound, "Empty");
        }
        [Route("api/client/deleteuser/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteUsers(int id)
        {
            var data = ClientService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/client/addpackage")]
        [HttpPost]
        public HttpResponseMessage AddPackage(BookingModel b)
        {
            if (ClientService.AddPackage(b))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Package added");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Try again!");
        }
        [Route("api/client/deletepackage/{id}")]
        [HttpGet]
        public HttpResponseMessage DeletePackage(int id)
        {
            var data = ClientService.DeletePackage(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
