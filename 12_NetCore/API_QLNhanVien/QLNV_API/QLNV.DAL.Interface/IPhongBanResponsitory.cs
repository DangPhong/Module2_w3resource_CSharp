using System;
using System.Collections.Generic;
using QLNV.Domain.Response;
using QLNV.Domain;
using QLNV.Domain.Request;

namespace QLNV.DAL.Interface
{
    public interface IPhongBanResponsitory
    {
        IList<PhongBan> DanhSachPhongBan();
        PhongBan LayPhongBanID(int Id);
        int TaoPhongBan(TaoPhongBan request);
        int SuaPhongBan(SuaPhongBan request);
        bool XoaPhongBan(int Id);
    }
}
