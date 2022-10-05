using System.Collections.Generic;
using mvc_app.Models;

namespace mvc_app.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Department> Departments {get; set;}
        public List<Shop> Shops {get; set;}
    }
}