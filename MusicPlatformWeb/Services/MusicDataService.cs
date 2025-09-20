using MusicClasses;
using MusicClasses.Interfaces;
using System.Security.Cryptography.X509Certificates;
namespace MusicPlatform.Services
{
    public class MusicDataService: IMusicDataService
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