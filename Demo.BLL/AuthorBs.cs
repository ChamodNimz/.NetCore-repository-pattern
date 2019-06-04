using Demo.DataAccess.Models;
using Demo.DataAccess.UnitOfWork;
using Demo.Utilities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BLL
{
    public class AuthorBs
    {
        ApiResponse _response = new ApiResponse();

        public ApiResponse GetAuthorsAndBooks(UnitOfWork uow)
        {
            try
            {
                var authorRepo = uow.AuthorRepository;
                var data = authorRepo.GetAllAuthorsWithBooks();

                _response.Data = data;
                _response.Message = "Authors ...!";
                _response.Status = 200;
                return _response;
            }
            catch (Exception ex)
            {
                return ApiResponse.Exception();
                throw;
            }
        }
    }
}
