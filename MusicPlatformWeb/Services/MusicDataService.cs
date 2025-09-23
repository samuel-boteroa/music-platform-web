using MusicClasses;
using MusicClasses.Interfaces;
using System.Security.Cryptography.X509Certificates;
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

            // Seed demo songs into the first two playlists for the dummy user
            if (playlists.Count >= 2)
            {
                var p1 = playlists[0];
                var p2 = playlists[1];

                // ~10 songs for playlist 1
                var demoSongsP1 = new List<Song>
                {
                    new Song("Midnight Groove") { duration = 210 },
                    new Song("Sunset Drive") { duration = 185 },
                    new Song("Neon Lights") { duration = 242 },
                    new Song("Echoes of You") { duration = 198 },
                    new Song("Skyline") { duration = 231 },
                    new Song("Ocean Breeze") { duration = 176 },
                    new Song("Afterglow") { duration = 204 },
                    new Song("Starlit Road") { duration = 223 },
                    new Song("City Nights") { duration = 189 },
                    new Song("Distant Thunder") { duration = 258 }
                };
                foreach (var s in demoSongsP1) { p1.addItem(s); }

                // ~5 songs for playlist 2
                var demoSongsP2 = new List<Song>
                {
                    new Song("Golden Hour") { duration = 200 },
                    new Song("Quiet Storm") { duration = 193 },
                    new Song("Velvet Sky") { duration = 236 },
                    new Song("First Light") { duration = 182 },
                    new Song("Silver Lining") { duration = 207 }
                };
                foreach (var s in demoSongsP2) { p2.addItem(s); }
            }

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


        public void addNewPlaylist(Guid userId, Playlist playlist)
        {
            // Safely try to get the user's list of playlists.
            if (this.programPlaylists.TryGetValue(userId, out List<Playlist> userPlaylists))
            {
                // SUCCESS: The user was found. Add the new playlist to their existing list.
                userPlaylists.Add(playlist);
            }
            else
            {
                // FAILURE: The user ID was not found. This is their first playlist.
                // 1. Create a brand new list for them.
                var newPlaylistList = new List<Playlist> { playlist };

                // 2. Add the new user ID and their new list to the dictionary.
                this.programPlaylists[userId] = newPlaylistList;
            }
        }

        public void deletePlaylist(Guid userId, Playlist playlistToDelete)
        {
            // Use TryGetValue for safety to get the user's list of playlists
            if (programPlaylists.TryGetValue(userId, out var playlists))
            {
                // Remove the specific playlist from that list
                playlists.Remove(playlistToDelete);
            }
        }
    }
}