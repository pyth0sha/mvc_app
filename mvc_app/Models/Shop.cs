using System.Collections.Generic;

namespace mvc_app.Models
{
    //класс цеха
    public class Shop
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<User> Users {get; set;} = new List<User>();
    }
}
