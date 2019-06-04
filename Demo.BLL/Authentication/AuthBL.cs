using Demo.DataAccess.UnitOfWork;
using Demo.Utilities;
using Demo.Utilities.Common;
using Demo.Utilities.Vms;
using System;
using System.Collections.Generic;
using System.Text;
namespace Demo.BLL.Authentication
{
    public class AuthBL
    {
        ApiResponse _response = new ApiResponse();

        public bool Authenticate(UnitOfWork uow, AuthVm authvm)
        {
            try
            {
                if(uow.UserRepository.IsExist(authvm.Username, authvm.Password))
                    return true;
                
                return false;

            }
            catch (Exception ex)
            {
                return false ;
                throw;
            }
        }
    }
}
