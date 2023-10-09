using Library.Model;
using System.Collections.Generic;

namespace Library.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<string> AvailableRoles { get; set; }
        public List<GadgetViewModel> Gadgets { get; set; }
    }
}
