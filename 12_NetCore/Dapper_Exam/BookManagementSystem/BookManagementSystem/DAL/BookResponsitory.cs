using BookManagementSystem.Models.Domain.Request;
using BookManagementSystem.Models.Domain.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem.DAL
{
    public class BookResponsitory : BaseResponsitory
    {
        public BookResponsitory() : base()
        {

        }
        public IEnumerable<BookGetAll> GetBooks()
        {
            List<BookGetAll> bookList = new List<BookGetAll>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                bookList = con.Query<BookGetAll>("Book_GetAll").ToList();
            }
            return bookList;
        }

        public IList<BookSearch> Search(string stringSearch)
        {
            IList<BookSearch> bookList;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                //if (con.State == ConnectionState.Closed)
                //{
                //    con.Open();
                //}
                //bookList = con.Query<BookSearch>("Book_Search").ToList();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@stringSearch", stringSearch);
             bookList = SqlMapper.Query<BookSearch>(con, "Book_Search", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
           
           
            return bookList;
        }
        public int Create(BookCreate bookCreate)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Avatar", bookCreate.Avatar);
                    parameters.Add("@Name", bookCreate.Name);
                    parameters.Add("@Author", bookCreate.Author);
                    parameters.Add("@Description", bookCreate.Description);
                    parameters.Add("@Year", bookCreate.Year);
                    parameters.Add("@Number", bookCreate.Number);
                    parameters.Add("@CateloryID", bookCreate.IDCatelory);
                    rowAffected = con.Execute("Book_Create", parameters, commandType: CommandType.StoredProcedure);
                }
                return rowAffected;
            }
        }

        public BookDetail Details(int id)
        {
            BookDetail book = new BookDetail();

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                book = con.Query<BookDetail>("Book_Detail", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return book;
        }
        public BookUpdate GetBookById(int id)
        {
            BookUpdate book = new BookUpdate();

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                book = con.Query<BookUpdate>("Book_GetByID", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return book;
        }

        public int Update(BookUpdate book)
        {
            int rowAffected = 0;

            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", book.ID);
                parameters.Add("@Avatar", book.Avatar);
                parameters.Add("@Name", book.Name);
                parameters.Add("@Author", book.Author);
                parameters.Add("@Description", book.Description);
                parameters.Add("@Year", book.Year);
                parameters.Add("@Number", book.Number);
                parameters.Add("@CateloryID", book.CateloryID);
                rowAffected = con.Execute("Book_Update", parameters, commandType: CommandType.StoredProcedure);
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
                rowAffected = con.Execute("Book_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowAffected;
        }

        public IEnumerable<CateloryGetAll> GetCatelories()
        {
            List<CateloryGetAll> cateloryList = new List<CateloryGetAll>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cateloryList = con.Query<CateloryGetAll>("Catelory_GetAll").ToList();
            }
            return cateloryList;
        }
    }
}
