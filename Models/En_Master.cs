namespace SchoolManagementERP.Models
{
    public class En_Master
    {
        public class MenuModel
        {
            public int ID { get; set; }
            public string Menu_Name { get; set; }
            public int? Parent_ID { get; set; }
            public string URL { get; set; }
            public int Seq { get; set; }
            public int ParentSeq { get; set; }
            public string Show { get; set; }
            public string Tooltip { get; set; }
            public string Spcial { get; set; }
            public string SessionCheck_Flag { get; set; }
            public string Type { get; set; }
            public int? Height { get; set; }
            public int? Width { get; set; }
            public int? Popup { get; set; }
            public int? UId { get; set; }
            public int? ShowZero { get; set; }
        }
    }
}
