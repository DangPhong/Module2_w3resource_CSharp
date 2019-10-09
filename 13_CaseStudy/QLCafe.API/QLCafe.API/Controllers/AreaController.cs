using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Response;

namespace QLCafe.API.Controllers
{

    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;

        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        [Route("api/area/getallarea")]
        public IEnumerable<Area> AreaGetAll()
        {
            return _areaService.AreaGetAll();
        }



    }
}
