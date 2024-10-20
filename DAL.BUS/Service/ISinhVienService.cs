using DAL.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BUS.Service
{
    public interface ISinhVienService
    {
        List<SinhVienVM> GetAll();
        string Create(SinhVienCreateVM vm);
        bool Update(SinhVienUpdateVM vm);
        bool Delete(int id);    
    }
}
