using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Request;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;

namespace QLCafe.BAL
{
    public class AreaService : IAreaService
    {
        private IAreaResponsitory _areaResponsitory;
        public AreaService(IAreaResponsitory areaResponsitory)
        {
            _areaResponsitory = areaResponsitory;
        }
        public bool AreaAdd(AreaAdd request)
        {
            return _areaResponsitory.AreaAdd(request);
        }

        public bool AreaDelete(int Id)
        {
            return _areaResponsitory.AreaDelete(Id);
        }

        public IList<Area> AreaGetAll()
        {
          return _areaResponsitory.AreaGetAll();
        }

        public Area AreaGetByID(int Id)
        {
            return _areaResponsitory.AreaGetByID(Id);
        }

        public bool AreaUpdate(AreaUpdate request)
        {
            return _areaResponsitory.AreaUpdate(request);
        }
    }
}
