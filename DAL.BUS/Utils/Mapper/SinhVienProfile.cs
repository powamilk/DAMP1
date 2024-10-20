using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.BUS.ViewModel;
using DAMP6.DAL.Entities;

namespace DAL.BUS.Utils.Mapper
{
    public class SinhVienMapping : Profile
    {
        public SinhVienMapping()
        {
            CreateMap<Sinhvien, SinhVienVM>().ReverseMap();
            CreateMap<Sinhvien, SinhVienCreateVM>().ReverseMap();   
            CreateMap<Sinhvien, SinhVienUpdateVM>().ReverseMap();   
        }
    }
}
