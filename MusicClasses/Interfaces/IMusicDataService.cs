using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses.Interfaces
{
    public interface IMusicDataService
    {
        public List<Playlist>? getUserPlaylists(User user);

        public void addNewPlaylist(Guid userId, Playlist newPlaylist);

        public void deletePlaylist(Guid userId,Playlist playlist);

        // Returns a list of songs available to add to the user's playlists (demo data)
        
    }
}
