using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.BLL;
using Demo.DataAccess.UnitOfWork;
using Demo.Utilities.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Data")]
    public class DataController : Controller
    {
        AuthorBs authorBs = new AuthorBs();
        private readonly UnitOfWork _uow;

        public DataController(UnitOfWork uow)
        {
            this._uow = uow;
        }

        // POST: api/Data
        [HttpPost]
        public ApiResponse Authenticate([FromBody]string value)
        {
            return null;
        }
    }
}
