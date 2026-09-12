using System.Data;
using static SchoolManagementERP.Models.En_Master;

namespace SchoolManagementERP.Interface
{
    public interface IMaster
    {
        List<MenuModel> GetMenuList();
    }
}
