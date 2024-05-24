namespace GronOgOlsenFrontEnd.Models
{
    public class UserCreationModel
    {
        private string? firstname;
        private string? lastname;
        private string? email;
        private string? username;
        private string? address;
        private string? phoneNumber;
        private string? password;


        public string? Firstname { get => firstname; set => firstname = value; }
        public string? Lastname { get => lastname; set => lastname = value; }
        public string? Email { get => email; set => email = value; }
        public string? Username { get => username; set => username = value; }
        public string? Address { get => address; set => address = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string? Password { get => password; set => password = value; }
    }
}
