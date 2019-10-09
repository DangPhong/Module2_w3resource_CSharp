using QLCafe.Domain.Request;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;

namespace QLCafe.BAL.Interface
{
    public interface IAreaService
    {
        IList<Area> AreaGetAll();
        Area AreaGetByID(int Id);
        bool AreaAdd(AreaAdd request);
        bool AreaUpdate(AreaUpdate request);
        bool AreaDelete(int Id);
    }
}
