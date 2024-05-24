using UserService.Models;

namespace GronOgOlsenFrontEnd.Services
{
    public class UserState
    {
        private UserModelDTO _user = new UserModelDTO();

        public UserModelDTO User
        {
            get => _user;
            set
            {
                if (_user != value)
                {
                    _user = value;
                    OnUserChanged();
                }
            }
        }

        public event Action UserChanged;

        public virtual void OnUserChanged()
        {
            UserChanged?.Invoke();
        }
    }
}
