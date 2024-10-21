using AutoMapper;
using DAL.BUS.Utils.Mapper;
using DAL.BUS.ViewModel;
using DAMP6.DAL;
using DAMP6.DAL.Entities;
using DAMP6.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BUS.Service
{
    public class SinhVienService : ISinhVienService
    {
        private readonly ISinhVienRepo _repo;
        private readonly AppDbContext _context;

        public SinhVienService()
        {
            _repo = new SinhVienRepo();
            _context = new AppDbContext();
        }

        public string Create(SinhVienCreateVM createVM)
        {
            Sinhvien entity = SinhVienMapping.MapCreateVMToEntity(createVM);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(int id)
        {
            var result = _repo.Delete(id);
            return result;
        }

        public List<SinhVienVM> GetAll()
        {
            var sinhViens = _repo.GetList();
            var sinhVienVMs = sinhViens.Select(sv => new SinhVienVM
            {
                Id = sv.Id,
                Ten = sv.Ten,
                Email = sv.Email,
                Sdt = sv.Sdt,
                Diachi = sv.Diachi,
                IdPh = sv.IdPh,
                PhuHuynh = sv.IdPhNavigation != null
                            ? new PhuHuynhVM
                            {
                                Id = sv.IdPhNavigation.Id,
                                Ten = sv.IdPhNavigation.Ten,
                                Nghenghiep = sv.IdPhNavigation.Nghenghiep
                            }
                            : null
            }).ToList();

            return sinhVienVMs;
        }

        public bool Update(SinhVienUpdateVM updateVM)
        {
            Sinhvien entity = SinhVienMapping.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }

        public List<PhuHuynhVM> GetAllPhuHuynh()
        {
            var phuHuynhs = _context.Phuhuynhs.ToList();
            var phuHuynhVMs = phuHuynhs.Select(ph => new PhuHuynhVM
            {
                Id = ph.Id,
                Ten = ph.Ten,
                Nghenghiep = ph.Nghenghiep
            }).ToList();

            return phuHuynhVMs;
        }
    }
}
