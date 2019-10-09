using System;
using System.Collections.Generic;
using BAL.Interface;
using DAL.Interface;
using Domain;

namespace BAL
{
    public class PhongBanService : IPhongBanService
    {
        IPhongBanRepository _phongBanRepository;
        public PhongBanService(IPhongBanRepository phongBanRepository)
        {
            _phongBanRepository = phongBanRepository;
        }
        public bool AddPhongBan(PhongBan phongBan)
        {
            return _phongBanRepository.AddPhongBan(phongBan);
        }

        public bool DeletePhongBan(int IDPhongBan)
        {
            return _phongBanRepository.DeletePhongBan(IDPhongBan);
        }

        public IList<PhongBanView> GetAllPhongBan()
        {
            return _phongBanRepository.GetAllPhongBan();
        }

        public PhongBan GetByPhongBanId(int phongBanId)
        {
            return _phongBanRepository.GetByPhongBanId(phongBanId);
        }

        public bool UpdatePhongBan(PhongBan phongBan)
        {
            return _phongBanRepository.UpdatePhongBan(phongBan);
        }
    }
}
