namespace GronOgOlsenFrontEnd.Models
{
    public class UserModelInteropablility
    {

        public Guid Id { get; set; } // UUIDs are represented as Guid in C#

        public string Username { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
