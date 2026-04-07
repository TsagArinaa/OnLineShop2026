namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PathImage { get; set; }

        public User(string name, string surname, string email, string pathImage= "/images/woman_avatar.png")
        {
            UserId = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Email = email;
            PathImage = pathImage;
        }
    }
}
