using MusicClasses;
using MusicPlatformWeb.ViewModels;



namespace MusicPlatformWeb.Pages
{
    public partial class PlaylistsManager
    {
        
        private List<Playlist> userPlaylists;

        private AddSongViewModel addSongModel;
        private string nombreUsuario;
        private bool addButtonOn;
        

        protected override void OnInitialized()
        {
            addButtonOn = false;
            addSongModel = new AddSongViewModel();
            nombreUsuario = _orchestrator.getCurrentUser().username;
            userPlaylists = _orchestrator.getPlaylists(_orchestrator.getCurrentUser());
        }

        private void showAddPlaylist() {
            addButtonOn = true;
            
        }



        private void addNewPlaylist() {
            Playlist newPlaylist = new(addSongModel.name);
            _orchestrator.addNewPlaylist(newPlaylist);
            userPlaylists = _orchestrator.getPlaylists(_orchestrator.getCurrentUser());
            addButtonOn= false;
        }

        private void DeletePlaylist(Playlist playlistToDelete)
        {
            
            _orchestrator.DeletePlaylist(playlistToDelete);
            userPlaylists = _orchestrator.getPlaylists(_orchestrator.getCurrentUser());
        }

        private void GoToPlaylist(Playlist playlist)
        {
            _nav.NavigateTo($"/player/{playlist.id}");
        }



    }
}
 