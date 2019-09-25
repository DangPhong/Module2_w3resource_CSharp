using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DatabaseFisrt_CRUD.Models
{
    public class EmployeeCreateModel
    {
        [Key]
        
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Tên nhân viên không hợp lệ")]
        [StringLength(maximumLength:50, MinimumLength =10,
            ErrorMessage ="Tên NV từ 10 đến 50 kí tự")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage ="Bạn phải nhập SĐT")]
        [RegularExpression(pattern: "(09|01[2|6|8|9])+([0-9]{8})",ErrorMessage ="Sđt ko đúng định dạng")]

        public string PhoneNumber { get; set; }

        public int SkillID { get; set; }

        [Required(ErrorMessage ="Bạn phải nhập số năm kinh nghiệm")]
        [Range(0,30,ErrorMessage ="Số năm kinh nghiệm từ 0 đến 30 năm")]
        public int YearsExperience { get; set; }

    }
}
