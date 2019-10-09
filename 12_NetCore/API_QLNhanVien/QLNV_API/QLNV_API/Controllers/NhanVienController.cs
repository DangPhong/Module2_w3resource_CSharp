using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNV.BAL.Interface;
using QLNV.Domain.Request;
using QLNV.Domain.Response;

namespace QLNV_API.Controllers
{
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _nhanVienService;

        public NhanVienController(INhanVienService nhanVienService)
        {
            _nhanVienService = nhanVienService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        [Route("api/nhanvien/danhsachnhanvientheophongban/{id}")]
        public IEnumerable<NhanVien> DanhSachNhanVienTheoPhongBan(int id)
        {
            return _nhanVienService.DanhSachNhanVienTheoPhongBan(id);
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/nhanvien/laynhanvien/{id}")]
        public NhanVien LayNhanVien(int id)
        {
            return _nhanVienService.LayNhanVienTheoID(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/nhanvien/taonhanvien")]
        public int TaoNhanVien([FromBody] TaoNhanVien request)
        {
            return _nhanVienService.TaoNhanVien(request);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/nhanvien/suanhanvien")]
        public int SuaNhanVien([FromBody] SuaNhanVien request)
        {
            return _nhanVienService.SuaNhanVien(request);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/nhanvien/xoanhanvien/{id}")]
        public bool Delete(int id) 
        {
            return _nhanVienService.XoaNhanVien(id);
        }
    }
}