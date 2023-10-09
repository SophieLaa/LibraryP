using System;

namespace Library.Web
{
    public class RoleMenu
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int MenuID { get; set; }
        public Role Role { get; set; }
        public Menu Menu { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime DeleteDate { get; set; }
    }
}
