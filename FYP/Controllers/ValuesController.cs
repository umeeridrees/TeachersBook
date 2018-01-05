using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace FYP.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            string a = "value";
            if (a!=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, a);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "object with " + id + " does not exist");
            }
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]string value)
        {
            try
            {
                //var message = Request.CreateResponse(HttpStatusCode.Created, CreatedObject);
                //message.Headers.Location = new Uri(Request.RequestUri + CreatedObject.ID.ToString());
                //return message;
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
            return null;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            //try
            //{
            //    find
            //    if (==null)
            //    {
            //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "object with " + id + " does not exist");
            //    }
            //    else
            //    {
            //        update;
            //        return Request.CreateResponse(HttpStatusCode.OK, objectUpdated);
            //    }
            //}
            //catch (Exception e)
            //{
            //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            //}
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            //try
            //{
            //    find
            //    if (==null)
            //    {
            //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "object with " + id + " does not exist");
            //    }
            //    else
            //    {
            //        remove;
            //        return Request.CreateResponse(HttpStatusCode.OK);
            //    }
            //}
            //catch (Exception e)
            //{
            //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            //}
            return null;
        }
    }
}
