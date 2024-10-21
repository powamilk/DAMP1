using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BUS.ViewModel
{
    public class PhuHuynhVM
    {
        public int Id { get; set; }

        public string Ten { get; set; } = null!;

        public string? Nghenghiep { get; set; }
    }
}
