using System;
using AutoMapper;
using Demo.BLL;
using Demo.DataAccess.UnitOfWork;
using Demo.Utilities.Common;
using Demo.Utilities.Vms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
  
    public class ValuesController : Controller
    {
        TestBs testBs = new TestBs();
        private UnitOfWork _uow;
        private readonly IMapper mapper;

        public ValuesController(UnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this.mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        
        public ApiResponse Get()
        {
            try
            {
                return testBs.TakeIt(_uow);
            }
            catch (Exception ex)
            {
                return ApiResponse.Exception();
                throw;
            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Authorize]
        public ApiResponse Get(int id)
        {
            return testBs.GetBook(_uow,id);
        }

        // POST api/values
        [HttpPost]
        public ApiResponse Post([FromBody]BookVm bookVm)
        {
            try
            {
                return testBs.AddBook(_uow, bookVm, mapper);
            }
            catch (Exception)
            {
                return ApiResponse.Exception();
                throw;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
