using QLNV.BAL.Interface;
using QLNV.DAL;
using QLNV.DAL.Interface;
using QLNV.Domain.Request;
using QLNV.Domain.Response;
using System;
using System.Collections.Generic;

namespace QLNV.BAL
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienResponsitory _nhanVienResponsitory;
        public NhanVienService(INhanVienResponsitory nhanVienResponsitory)
        {
            _nhanVienResponsitory = nhanVienResponsitory;
        }

        public IList<NhanVien> DanhSachNhanVienTheoPhongBan(int phongBanId)
        {
            return _nhanVienResponsitory.DanhSachNhanVienTheoPhongBan(phongBanId);
        }

        public NhanVien LayNhanVienTheoID(int maNV)
        {
            return _nhanVienResponsitory.LayNhanVienTheoID(maNV);
        }

        public int SuaNhanVien(SuaNhanVien request)
        {
            return _nhanVienResponsitory.SuaNhanVien(request);
        }

        public int TaoNhanVien(TaoNhanVien request)
        {
            return _nhanVienResponsitory.TaoNhanVien(request);
        }

        public bool XoaNhanVien(int maNV)
        {
            return _nhanVienResponsitory.XoaNhanVien(maNV);
        }
    }
}
