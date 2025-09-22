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
                newUser = new User(userViewModel.Password, userViewModel.Email, userViewModel.Password);
                _orchestrator.registerUser(newUser);
            }
            else
            {
                newUser = new User(userViewModel.Username, userViewModel.Email, userViewModel.Password,
                    userViewModel.Birthday);
                _orchestrator.registerUser(newUser);

            }
            _nav.NavigateTo("/playlists");
        }

    }
}
