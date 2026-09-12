using SchoolManagementERP.Interface;
using SchoolManagementERP.Models;
using SchoolManagementERP.SqlHelper;
using System.Data;
using static SchoolManagementERP.Models.En_Master;

namespace SchoolManagementERP.DataAccess
{
    public class MasterData:IMaster
    {
        private readonly SqlHelpers _objSql;
        public MasterData(SqlHelpers objSql)
        {
            _objSql = objSql;
        }


        public List<MenuModel> GetMenuList()
        {
            DataTable dt = _objSql.ExecuteDataTable(
                " SELECT * FROM ol_tblmainmenu ",
                "",
                []
            );

            List<MenuModel> menuList = new List<MenuModel>();

            foreach (DataRow row in dt.Rows)
            {
                menuList.Add(new MenuModel
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Menu_Name = row["Menu_Name"]?.ToString(),
                    Parent_ID = row["Parent_ID"] == DBNull.Value
                                ? null
                                : Convert.ToInt32(row["Parent_ID"]),
                    URL = row["URL"]?.ToString(),
                    Seq = row["seq"] == DBNull.Value ? 0 : Convert.ToInt32(row["seq"]),
                    ParentSeq = row["ParentSeq"] == DBNull.Value ? 0 : Convert.ToInt32(row["ParentSeq"]),
                    Show = row["Show"]?.ToString(),
                    Tooltip = row["Tooltip"]?.ToString(),
                    Spcial = row["Spcial"]?.ToString(),
                    SessionCheck_Flag = row["SessionCheck_Flag"]?.ToString(),
                    Type = row["Type"]?.ToString(),
                    Height = row["height"] == DBNull.Value ? null : Convert.ToInt32(row["height"]),
                    Width = row["width"] == DBNull.Value ? null : Convert.ToInt32(row["width"]),
                    Popup = row["Popup"] == DBNull.Value ? null : Convert.ToInt32(row["Popup"]),
                    UId = row["UId"] == DBNull.Value ? null : Convert.ToInt32(row["UId"]),
                    ShowZero = row["ShowZero"] == DBNull.Value ? null : Convert.ToInt32(row["ShowZero"])
                });
            }

            return menuList;
        }
    }
}
