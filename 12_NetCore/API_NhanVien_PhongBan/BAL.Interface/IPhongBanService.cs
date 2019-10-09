using Domain;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface IPhongBanService
    {
        bool AddPhongBan(PhongBan phongBan);
        bool UpdatePhongBan(PhongBan phongBan);
        bool DeletePhongBan(int IDPhongBan);
        IList<PhongBanView> GetAllPhongBan();
        PhongBan GetByPhongBanId(int phongBanId);
    }
}
