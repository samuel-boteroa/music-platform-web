using MusicClasses;
using MusicPlatformWeb.ViewModels;

namespace MusicPlatformWeb.Pages
{
    public partial class Register
    {
        RegistrationUserViewModel userViewModel = new();
        string submission = null;
        User? newUser;

        public void HandleFormSubmission()
        {
            if (userViewModel.Birthday == null)
            {
                // Username must be used as the first parameter, not Password
                newUser = new User(userViewModel.Username, userViewModel.Email, userViewModel.Password);
                _orchestrator.registerUser(newUser);
            }
            else
            {
                newUser = new User(userViewModel.Username, userViewModel.Email, userViewModel.Password,
                    userViewModel.Birthday);
                _orchestrator.registerUser(newUser);

            }
            // After registration, send the user to login instead of auto-logging in
            _nav.NavigateTo("/login");
        }

    }
}
