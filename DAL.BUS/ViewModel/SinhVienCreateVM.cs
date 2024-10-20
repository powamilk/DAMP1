using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BUS.ViewModel
{
    public class SinhVienCreateVM
    {
        public int Id { get; set; }

        public string Ten { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Sdt { get; set; }

        public string? Diachi { get; set; }

        public int? IdPh { get; set; }
    }
}
