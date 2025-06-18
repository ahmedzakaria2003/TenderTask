using System;
using System.Collections.Generic;
using AutoMapper;
using TenderTask.DataAccess.Models;
using TenderTask.BusinessLogic.DataTransferObjects;

namespace TenderTask.BusinessLogic.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Tender, TenderDTO>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.Tenders, opt => opt.MapFrom(src => src.Tenders));
        }
    }
}
