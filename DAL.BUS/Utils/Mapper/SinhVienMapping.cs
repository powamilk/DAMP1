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
    public class SinhVienMapping
    {
        public static SinhVienVM MapEntityToVM(Sinhvien entity)
        {
            return new()
            {
                Id = entity.Id,
                Ten = entity.Ten,
                Email = entity.Email,
                Sdt = entity.Sdt,
                Diachi = entity.Diachi,
                IdPh = entity.IdPh,
            };
        }

        public static Sinhvien MapCreateVMToEntity(SinhVienCreateVM createVM)
        {
            return new()
            {
                Id = createVM.Id,
                Ten = createVM.Ten,
                Email = createVM.Email,
                Sdt = createVM.Sdt,
                Diachi = createVM.Diachi,
                IdPh = createVM.IdPh,
            };
        }

        public static Sinhvien MapUpdateVMToEntity(SinhVienUpdateVM updateVM)
        {
            return new()
            {
                Id = updateVM.Id,
                Ten = updateVM.Ten,
                Email = updateVM.Email,
                Sdt = updateVM.Sdt,
                Diachi = updateVM.Diachi,
                IdPh = updateVM.IdPh,
            };
        }
    }
}
