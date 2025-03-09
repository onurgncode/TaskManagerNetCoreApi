namespace StaticKimlikKarti.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }  // Şifreler, gerçek projelerde hashlenmiş olmalı.
        public string Role { get; set; } // Kullanıcı rolü (Admin, User, vb.)
    }
}
