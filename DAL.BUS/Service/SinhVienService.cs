using AutoMapper;
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
        private readonly IMapper _mapper;

        public SinhVienService()
        {
            _repo = new SinhVienRepo();
            _context = new AppDbContext();
        }
        public string Create(SinhVienCreateVM vm)
        {
            Sinhvien entity = _mapper.Map<Sinhvien>(vm); 
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
            List<Sinhvien> entities = _repo.GetList();  
            var vms = _mapper.Map<List<SinhVienVM>>(entities);
            return vms;
        }

        public bool Update(SinhVienUpdateVM vm)
        {
            Sinhvien entity = _mapper.Map<Sinhvien>(vm);
            var result = _repo.Update(entity);
            return result;
        }
    }
}
