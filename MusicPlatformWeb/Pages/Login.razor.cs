using MusicPlatformWeb.ViewModels;

namespace MusicPlatformWeb.Pages
{
    public partial class Login
    {
        LoginUserViewModel userLogin = new();
        public void login()
        {
            _orchestrator.validateUserInformation(userLogin.Username, userLogin.Password);
            _nav.NavigateTo("/playlists");
        }

    }
}
