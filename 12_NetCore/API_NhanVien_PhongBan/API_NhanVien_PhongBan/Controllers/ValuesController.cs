using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Domain;
namespace API_NhanVien_PhongBan.Controllers
{
    
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IPhongBanService _phongBanService;
        public ValuesController(IPhongBanService phongBanService)
        {
            _phongBanService = phongBanService;
        }
        // GET api/values
        [HttpGet]
        [Route("api/phongban/gets")]
        public IList<PhongBanView> Gets()
        {
            return _phongBanService.GetAllPhongBan();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/phongban/get/{id}")]
        public PhongBan Get(int id)
        {
            return _phongBanService.GetByPhongBanId(id);
        }

        //// POST api/values
        [HttpPost]
        [Route("api/phongban/create")]
        public void Create([FromBody] PhongBan phongBan)
        {
            _phongBanService.AddPhongBan(phongBan);
        }

        //// PUT api/values/5
        [HttpPut("{id}")]
        [Route("api/phongban/update")]
        public void Update([FromBody] PhongBan phongBan)
        {
            _phongBanService.UpdatePhongBan(phongBan);
        }

        //// DELETE api/values/5
        [HttpDelete("{id}")]
        [Route("api/phongban/delete")]
        public void Delete(int id)
        {
            _phongBanService.DeletePhongBan(id);
        }
    }
}
