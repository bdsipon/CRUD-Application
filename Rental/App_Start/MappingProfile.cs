using AutoMapper;
using Rental.DTOs;
using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<MovieDto, Movie>();
            CreateMap<Movie, MovieDto>();
        }
    }
}