using Library.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Menu
{
    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    public string MenuName { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ChangeDate { get; set; }

    public DateTime DeleteDate { get; set; }

    [StringLength(100)]
    public string Url { get; set; } 

    public int? ParentID { get; set; }
    public Menu ParentMenu { get; set; }

    public virtual List<RoleMenu> RoleMenus { get; set; }
    public virtual List<Menu> ChildMenus { get; set; }
}
