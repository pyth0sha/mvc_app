using System.Collections.Generic;

namespace mvc_app.Models
{
    // класс отдела
    // TODO:
    // [+] добавить отношение к цеху List<Shop>
    // [] 
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Shop> Shops { get; set; }

        public Department()
        {
            Shops = new List<Shop>();
        }
        
    }
}
