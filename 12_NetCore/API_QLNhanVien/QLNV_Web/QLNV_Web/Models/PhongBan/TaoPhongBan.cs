using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV_Web.Models.PhongBan
{
    public class TaoPhongBan
    {
        [Display(Name = "Mã phòng ban")]
        [Required(ErrorMessage = "Bạn phải nhập mã phòng ban")]
        [StringLength(maximumLength:5,ErrorMessage ="Mã phòng ban phải có 5 kí tự")]
        public string MaPhongBan { get; set; }
        [Display(Name = "Tên phòng ban ")]
        [Required(ErrorMessage = "Bạn phải nhập tên phòng ban")]
        [StringLength(maximumLength: 50, MinimumLength =1, ErrorMessage = "Tên phòng ban từ 1 đến 50 kí tự")]
        public string TenPhongBan { get; set; }
       
    }
}
