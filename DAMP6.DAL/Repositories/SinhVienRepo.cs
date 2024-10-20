using DAMP6.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMP6.DAL.Repositories
{
    public class SinhVienRepo : ISinhVienRepo
    {
        AppDbContext _context;
        public SinhVienRepo()
        {
            _context = new();
        }
        public string Create(Sinhvien sv)
        {
            try
            {
                _context.Add(sv);
                _context.SaveChanges();
                return "Thêm Thành công";
            }
            catch (Exception ex)
            {
                return "Thêm Thất Bại";
            } 
            
        }

        public bool Delete(int id)
        {
            try
            {
                var queryable = _context.Sinhviens.AsQueryable();
                Sinhvien sinhVien = queryable.FirstOrDefault(e => e.Id == id);

                _context.Remove(sinhVien);
                _context.SaveChanges();
                return true;
            }
            catch
            { return false; }   
        }

        public List<Sinhvien> GetList()
        {
            var queryable = _context.Sinhviens.AsQueryable();
            List<Sinhvien> sinhviens = queryable.ToList();  
            return sinhviens;
        }

        public List<Sinhvien> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sinhvien sv)
        {
            try
            {
                var queryable = _context.Sinhviens.AsQueryable();
                Sinhvien sinhvien = queryable.FirstOrDefault(e => e.Id == sv.Id);

                sinhvien.Ten = sv.Ten;
                sinhvien.Diachi = sv.Diachi;
                sinhvien.Email = sv.Email;
                sinhvien.Sdt = sv.Sdt;
                sinhvien.IdPh = sv.IdPh;

                _context.Update(sinhvien);
                _context.SaveChanges();

                return true;
            }
            catch
            { return false; }
        }
    }
}
