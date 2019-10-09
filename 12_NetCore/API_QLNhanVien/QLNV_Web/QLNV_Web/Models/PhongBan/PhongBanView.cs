using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 
namespace QLNV_Web.Models.PhongBan
{
    public class PhongBanView
    {
        public int ID { get; set; }
        [Display(Name = "Mã phòng ban")]
        public string MaPhongBan { get; set; }
        [Display(Name ="Tên phòng ban ")]
        public string TenPhongBan { get; set; }
        [Display(Name = "Tổng số nhân viên ")]
        public int TongSoNhanVien { get; set; }
    }
}
