using ABCEnglishCenter.Models.Domain.Request;
using ABCEnglishCenter.Models.Domain.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ABCEnglishCenter.DAL
{
    public class StudentResponsitory :BaseResponsitory
    {
        public StudentResponsitory() : base()
        {

        }

        public IEnumerable<Student> GetStudents(string stringSearch)
         {
            List<Student> students = new List<Student>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@stringSearch", stringSearch);
                    students = con.Query<Student>("Student_GetAll", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return students;
        }
        public IEnumerable<Level> GetLevels()
        {
            List<Level> levels = new List<Level>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                levels = con.Query<Level>("Level_GetAll").ToList();
            }
            return levels;
        }
        public IEnumerable<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                languages = con.Query<Language>("Language_GetAll").ToList();
            }
            return languages;
        }

        public int Create(StudentCreate studentCreate)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Name", studentCreate.Name);
                    parameters.Add("@DOB", studentCreate.DOB);
                    parameters.Add("@Gender", studentCreate.Gender);
                    parameters.Add("@Email", studentCreate.Email);
                    parameters.Add("@LevelID", studentCreate.LevelID);
                    parameters.Add("@LanguageID", studentCreate.LanguageID);
                    rowAffected = con.Execute("Student_Create", parameters, commandType: CommandType.StoredProcedure);
                }
                return rowAffected;
            }
        }
        public StudentDetail Details(int id)
        {
            StudentDetail student = new StudentDetail();

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                student = con.Query<StudentDetail>("Student_Detail", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return student;
        }
        public StudentUpdate GetStudentById(int id)
        {
            StudentUpdate student = new StudentUpdate();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                student = con.Query<StudentUpdate>("Student_GetById", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return student;
        }
        public int Update(StudentUpdate student)
        {
            int rowAffected = 0;

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", student.ID);
                parameters.Add("@Name", student.Name);
                parameters.Add("@DOB", student.DOB);
                parameters.Add("@Gender", student.Gender);
                parameters.Add("@Email", student.Email);
                parameters.Add("@LevelID", student.LevelID);
                parameters.Add("@LanguageID", student.LanguageID);
                rowAffected = con.Execute("Student_Update", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowAffected;
        }
        public int Delete(int id)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                rowAffected = con.Execute("Student_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowAffected;
        }
    }
}
