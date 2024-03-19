using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Configuration;
using WebApplication5.Models;
using WebApplication5.Dtos;
using AutoMapper;

namespace WebApplication5.App_Start
{
    public class MappingContext : Profile
    { 
            public MappingContext() 
        {
        
            CreateMap<Customer, CustomerDto>();
        
        }
       
    }
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingContext>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}