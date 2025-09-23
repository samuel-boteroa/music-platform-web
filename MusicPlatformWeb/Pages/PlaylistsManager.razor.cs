using Microsoft.AspNetCore.Components;
using MusicClasses;
using MusicClasses.Interfaces;

namespace MusicPlatformWeb.Pages
{
    public partial class PlaylistsManager
    {
        [Inject]
        private IMusicDataService MusicDataService { get; set; } = default!;

        [Inject]
        private IUserDataService UserDataService { get; set; } = default!;

        private List<Playlist> userPlaylists = new();
        private User? currentUser;

        private Playlist newPlaylist = new Playlist();

        protected override async Task OnInitializedAsync()
        {
            // Obtener usuario actual (simulado)
            currentUser = await UserDataService.GetUserByUsernameAsync("demo") 
                          ?? new User { Id = 1, UserName = "demo" };

            userPlaylists = await MusicDataService.GetUserPlaylistsAsync(currentUser.Id);
        }

        private async Task CreatePlaylist()
        {
            if (currentUser != null && !string.IsNullOrWhiteSpace(newPlaylist.Name))
            {
                await MusicDataService.AddPlaylistAsync(currentUser.Id, new Playlist
                {
                    Name = newPlaylist.Name,
                    Description = newPlaylist.Description
                });

                // Refrescar lista
                userPlaylists = await MusicDataService.GetUserPlaylistsAsync(currentUser.Id);

                // Limpiar formulario
                newPlaylist = new Playlist();
            }
        }
    }
}


 
