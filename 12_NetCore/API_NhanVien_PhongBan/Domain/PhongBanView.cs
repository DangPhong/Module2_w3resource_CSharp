using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class PhongBanView
    {
        public int IDPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public bool IsDeleted { get; set; }
        public int SoLuongNV { get; set; }
    }
}
