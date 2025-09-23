using MusicClasses;
using MusicClasses.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicPlatformWeb.Services
{
    public class MusicDataService : IMusicDataService
    {
        private readonly Dictionary<Guid, List<Playlist>> programPlaylists;

        public MusicDataService()
        {
            var dummyId = new Guid("11223344-5566-7788-99aa-bbccddeeff00");

            var playlists = new List<Playlist>
            {
                new Playlist("Suavemente"),
                new Playlist("Esquelefacina"),
                new Playlist("Perreo")
            };

            programPlaylists = new Dictionary<Guid, List<Playlist>>
            {
                { dummyId, playlists }
            };
        }

        // Método asíncrono con PascalCase
        public async Task<List<Playlist>> GetUserPlaylistsAsync(User user)
        {
            if (programPlaylists.TryGetValue(user.id, out var playlists))
            {
                return await Task.FromResult(playlists);
            }

            return await Task.FromResult(new List<Playlist>());
        }
    }
}
