using AutoMapper;
using Demo.DataAccess.Models;
using Demo.Utilities.Vms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookVm>();
            CreateMap<User, AuthVm>();
        }
    }
}
