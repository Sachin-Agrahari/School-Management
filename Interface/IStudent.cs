using SchoolManagementERP.DataAccess;
using System.Data;

namespace SchoolManagementERP.Interface
{
    public interface IStudent
    {
        DataTable GetStudentData();
    }
}
