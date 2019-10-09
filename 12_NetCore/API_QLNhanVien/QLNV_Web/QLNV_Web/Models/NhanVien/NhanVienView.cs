using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QLNV_Web.Models.NhanVien
{
    public class NhanVienView
    {
        [Display(Name = "Mã nhân viên")]
        public int MaNV { get; set; }
        [Display(Name = "Họ")]
        public string Ho { get; set; }
        [Display(Name = "Tên")]
        public string Ten { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Phòng ban")]
        public int PhongBanId { get; set; }
    }
}
