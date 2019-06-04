
using System.Collections.Generic;
using Demo.BLL.Authentication;
using Demo.DataAccess.UnitOfWork;
using Demo.Services;
using Demo.Utilities.Common;
using Demo.Utilities.Vms;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        private UnitOfWork _uow;
        private AuthBL authBl = new AuthBL();
        private AuthService authService;

        public AuthController(UnitOfWork uow, AuthService authService)
        {
            this._uow = uow;
            this.authService = authService;
        }

       

        // GET: api/Auth
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        // POST: api/Auth
        [HttpPost]
        public ApiResponse Post([FromBody]AuthVm authVm)
        {
            try
            {
                if (authBl.Authenticate(_uow, authVm))
                {
                    return new ApiResponse() { Data = authService.GenerateToken(), Message = "Success", Status = 200 };
                }
                return  new ApiResponse(){ Data = null, Message = "unauthorized", Status = 200 };
            }
            catch (System.Exception ex)
            {
                return ApiResponse.Exception();
                throw;
            }
            
        }
        
    }
}
