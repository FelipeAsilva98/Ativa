using Investment.Models;
using Investment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Investment.Controllers
{
    public class FundosController : ApiController
    {
        static readonly IFundosRepositorio repositorio = new FundosRepositorio();

        public IEnumerable<Fundos> GetAllFundos()
        {
            return repositorio.GetAll();
        }

        /*public Fundos GetFundos(Guid id)
        {
            Fundos empresa = repositorio.Get(id);
            if(empresa == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return empresa;
        }*/

        public HttpResponseMessage PostEmpresa(Fundos empresa)
        {
            empresa = repositorio.Add(empresa);
            var response = Request.CreateResponse<Fundos>(HttpStatusCode.Created, empresa);
            string uri = Url.Link("DefaultApi", new { id = empresa.id });
            response.Headers.Location = new Uri(uri);
            return response;
        }
    }
}
