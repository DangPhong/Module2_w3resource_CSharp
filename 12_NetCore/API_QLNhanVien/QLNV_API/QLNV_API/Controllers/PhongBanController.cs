using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLNV.BAL;
using QLNV.BAL.Interface;
using QLNV.Domain.Request;
using QLNV.Domain.Response;

namespace QLNV_API.Controllers
{
    
    [ApiController]
    public class PhongBanController : ControllerBase
    {
        private readonly IPhongBanService _phongBanService;
        
        public PhongBanController(IPhongBanService phongBanService)
        {
            _phongBanService = phongBanService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        [Route("api/phongban/danhsachphongban")]
        public IEnumerable<PhongBan> DanhSachPhongBan()
        {
            return _phongBanService.DanhSachPhongBan();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/phongban/layphongban/{id}")]
        public PhongBan LayPhongBanID(int id)
        {
            return _phongBanService.LayPhongBanID(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/phongban/taophongban")]
        public int TaoPhongBan([FromBody] TaoPhongBan request)
        {
            return _phongBanService.TaoPhongBan(request);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/phongban/suaphongban")]
        public int SuaPhongBan( [FromBody] SuaPhongBan request)
        {
            return _phongBanService.SuaPhongBan(request);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/phongban/xoaphongban/{id}")]
        public bool Delete(int id)
        {
            return _phongBanService.XoaPhongBan(id);
        }
    }
}
