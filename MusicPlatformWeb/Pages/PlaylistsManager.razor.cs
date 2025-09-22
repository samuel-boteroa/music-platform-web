using MusicClasses;


namespace MusicPlatformWeb.Pages
{
    public partial class PlaylistsManager
    {
        private string nombreUsuario;
        private List<Playlist> userPlaylists;

        protected override void OnInitialized()
        {
            nombreUsuario = _orchestrator.getCurrentUser().username;
            userPlaylists = _orchestrator.getPlaylists(_orchestrator.getCurrentUser());
        }
    }
}
 