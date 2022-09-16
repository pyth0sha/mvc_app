namespace mvc_app.Models
{
    // класс пользователя
    public class User
    {
        //TODO:
        //[] добавить отношение к цеху
        //
        public int Id { get; set; }
        //public string Name { get; set; }
        public string Number { get; set; } // u12345
        public string Password { get; set; }
        
        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public int? ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
