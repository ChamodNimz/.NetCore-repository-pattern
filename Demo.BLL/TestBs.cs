using AutoMapper;
using Demo.DataAccess.Contracts;
using Demo.DataAccess.Models;
using Demo.DataAccess.UnitOfWork;
using Demo.Utilities.Common;
using Demo.Utilities.Vms;
using System;


namespace Demo.BLL
{
    public class TestBs
    {

        ApiResponse _response = new ApiResponse();

        public ApiResponse TakeIt(UnitOfWork uow)
        {
            try
            {
                var bookRepository = uow.GenericRepository<Book>();
                _response.Data = bookRepository.GetAll();
                _response.Message = "";
                _response.Status = 200;
                return _response;
            }
            catch (Exception ex)
            {
                _response.Data = null;
                _response.Message = "";
                _response.Status = 200;
                return _response;

                throw ex;
            }
           
        }

        public ApiResponse GetBook(UnitOfWork uow, int id)
        {
            try
            {
                var bookRepo = uow.GenericRepository<Book>();
                var book = bookRepo.GetById(id);

                _response.Data = book;
                _response.Message = "Books received ..!";
                _response.Status = 200;
                return _response;
            }
            catch (Exception ex)
            {
                return ApiResponse.Exception();
                throw;
            }
            
        }

        public ApiResponse AddBook(UnitOfWork uow, BookVm bookVm, IMapper mapper)
        {
            try
            {
                Book book = new Book();
                mapper.Map(bookVm, book);
                uow.CreateTransaction();
                uow.GenericRepository<Book>().Insert(book);
                uow.Save();
                uow.Commit();

                _response.Data = null;
                _response.Message = "Successfully inserted ...!";
                _response.Status = 200;

                return _response;
            }
            catch (Exception ex)
            {
                uow.Rollback();
                ApiResponse.Exception();
                throw;
            }
        }
    }
}
