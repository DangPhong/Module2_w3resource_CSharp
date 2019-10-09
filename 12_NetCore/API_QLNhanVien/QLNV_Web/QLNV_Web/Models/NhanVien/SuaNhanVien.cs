using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV_Web.Models.NhanVien
{
    public class SuaNhanVien
    {
        [Display(Name = "Họ")]
        [Required(ErrorMessage = "Bạn phải nhập họ nhân viên")]
        [StringLength(maximumLength: 20, MinimumLength = 1, ErrorMessage = "Họ phải có ít nhất từ 1 đến 20 kí tự")]
        public string Ho { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập tên nhân viên")]
        [StringLength(maximumLength: 20, MinimumLength = 1, ErrorMessage = "Tên phải có ít nhất từ 1 đến 20 kí tự")]
        [Display(Name = "Tên")]
        public string Ten { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Bạn phải nhập địa chỉ nhân viên")]
        [StringLength(maximumLength: 250, ErrorMessage = "Địa chỉ nhập dưới 250 kí tự")]
        public string DiaChi { get; set; }
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Phòng ban")]
        public int PhongBanId { get; set; }
    }
}
