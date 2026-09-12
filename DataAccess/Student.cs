using Microsoft.Data.SqlClient;
using SchoolManagementERP.Interface;
using SchoolManagementERP.SqlHelper;
using System.Data;


namespace SchoolManagementERP.DataAccess
{
    public class Student:IStudent
    {
        private readonly SqlHelpers _objSql;
        public Student(SqlHelpers objSql)
        {
            _objSql = objSql;
        }

        public DataTable GetStudentData()
        {
            string str = "";
            str = " SELECT TOP 10 * FROM EMPLOYEE ";
            DataTable dt = _objSql.ExecuteDataTable(str, "",[]);
            return dt;
        }
    }
}
