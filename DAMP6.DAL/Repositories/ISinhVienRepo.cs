using DAMP6.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMP6.DAL.Repositories
{
    public interface ISinhVienRepo
    {
        List<Sinhvien> GetList(); 
        List<Sinhvien> GetListById(int id);
        string Create(Sinhvien sv);
        bool Update(Sinhvien sv);
        bool Delete(int id);    
    }
}
