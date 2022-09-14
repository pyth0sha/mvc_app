using System.Collections.Generic;

namespace mvc_app.Models
{
    public class User
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public Role Role {
            //get => Role.Name;
            get;
            set;
        }

    }
}
