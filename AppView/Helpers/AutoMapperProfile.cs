﻿using AppView.Data;
using AppView.ViewModels;
using AutoMapper;

namespace AppView.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterVM, KhachHang>();
                //.ForMember(kh => kh.HoTen, option => option.MapFrom(RegisterVM =>
                //RegisterVM.HoTen))
                //.ReverseMap();
        }
    }
}
