using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PhongBanDapper.Models
{
    public class PhongBanCreateView
    {
        public int IDPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        //public bool IsDeleted { get; set; }
        public int SoLuongNV { get; set; }
    }
}
