using QLNV.BAL.Interface;
using QLNV.DAL;
using QLNV.DAL.Interface;
using QLNV.Domain.Request;
using QLNV.Domain.Response;
using System;
using System.Collections.Generic;

namespace QLNV.BAL
{
    public class PhongBanService : IPhongBanService
    {
        private IPhongBanResponsitory _phongBanResponsitory;
        public PhongBanService(IPhongBanResponsitory phongBanResponsitory)
        {
            _phongBanResponsitory = phongBanResponsitory;
        }

        public IList<PhongBan> DanhSachPhongBan()
        {
            return _phongBanResponsitory.DanhSachPhongBan();
        }

        public PhongBan LayPhongBanID(int Id)
        {
            return _phongBanResponsitory.LayPhongBanID(Id);
        }

        public int SuaPhongBan(SuaPhongBan request)
        {
            return _phongBanResponsitory.SuaPhongBan(request);
        }

        public int TaoPhongBan(TaoPhongBan request)
        {
            return _phongBanResponsitory.TaoPhongBan(request);
        }

        public bool XoaPhongBan(int Id)
        {
            return _phongBanResponsitory.XoaPhongBan(Id);
        }
    }
}
