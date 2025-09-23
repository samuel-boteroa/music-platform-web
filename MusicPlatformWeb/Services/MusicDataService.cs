using MusicClasses;
using MusicClasses.Interfaces;

namespace MusicPlatformWeb.Services
{
    public class MusicDataService: IMusicDataService
    {
        private readonly Dictionary<int, List<Playlist>> programPlaylists;

        public MusicDataService()
        {
            programPlaylists = new Dictionary<int, List<Playlist>>();

            // Usuario ficticio con ID = 1
            programPlaylists[1] = new List<Playlist>
            {
                new Playlist { Name = "Suavemente", Description = "Clásicos de merengue" },
                new Playlist { Name = "Esquelefacina", Description = "Lo mejor del perreo" }
            };
        }

        public async Task<List<Playlist>> GetUserPlaylistsAsync(int userId)
        {
            if (programPlaylists.TryGetValue(userId, out var playlists))
                return await Task.FromResult(playlists);

            return new List<Playlist>();
        }

        public List<Playlist> getUserPlaylists(User user)
        {
            if (programPlaylists.TryGetValue(user.id, out var playlists))
            {
                return playlists;
            }

            return new List<Playlist>();
        }
    }
}