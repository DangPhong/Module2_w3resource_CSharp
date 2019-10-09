using System;
using System.Collections.Generic;
using QLNV.Domain.Response;
using QLNV.Domain;
using QLNV.Domain.Request;

namespace QLNV.DAL.Interface
{
    public interface INhanVienResponsitory
    {
        IList<NhanVien> DanhSachNhanVienTheoPhongBan (int phongBanId);
        NhanVien LayNhanVienTheoID(int maNV);
        int TaoNhanVien(TaoNhanVien request);
        int SuaNhanVien(SuaNhanVien request); 
        bool XoaNhanVien(int maNV);
    }
}
