using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DAL.Interface;
using Dapper;
using Domain;

namespace DAL
{
    public class PhongBanRepository : BaseRepository, IPhongBanRepository
    {
        public bool AddPhongBan(PhongBan phongBan)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TenPhongBan", phongBan.TenPhongBan);
            parameters.Add("@IsDelete", phongBan.IsDeleted);
            SqlMapper.Execute(con, "AddPhongBan", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeletePhongBan(int IDPhongBan)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDPhongBan", IDPhongBan);
            SqlMapper.Execute(con, "DeletePhongBan", param: parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public IList<PhongBanView> GetAllPhongBan()
        {
            IList<PhongBanView> customerList = SqlMapper.Query<PhongBanView>(con, "GetAllPhongBan", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
        }

        public PhongBan GetByPhongBanId(int phongBanId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDPhongBan", phongBanId);
                return SqlMapper.Query<PhongBan>((SqlConnection)con, "GetByPhongBanId", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdatePhongBan(PhongBan phongBan)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDPhongBan", phongBan.IDPhongBan);
                parameters.Add("@TenPhongBan", phongBan.TenPhongBan);
                //parameters.Add("@UserEmail", phongBan.IsDeleted);

                SqlMapper.Execute(con, "AddPhongBan", param: parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
