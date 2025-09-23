using Microsoft.AspNetCore.Components;
using MusicClasses;
using MusicClasses.Interfaces;

namespace MusicPlatformWeb.Pages
{
    public partial class PlaylistsManager
    {
        [Inject] private IUserDataService UserDataService { get; set; } = default!;
        [Inject] private IMusicDataService MusicDataService { get; set; } = default!;

        private string nombreUsuario = string.Empty;
        private List<Playlist> userPlaylists = new();
        private User? currentUser;

        protected override async Task OnInitializedAsync()
        {
            // 1. Obtener el usuario actual (o de prueba si no existe)
            currentUser = UserDataService.GetCurrentUser();
            if (currentUser == null)
            {
                currentUser = UserDataService.GetTestUser();
                UserDataService.SetCurrentUser(currentUser);
            }

            nombreUsuario = currentUser?.username ?? "Invitado";

            // 2. Cargar playlists del usuario
            if (currentUser != null)
            {
                userPlaylists = await MusicDataService.GetUserPlaylistsAsync(currentUser);
            }
        }
    }
}

 
