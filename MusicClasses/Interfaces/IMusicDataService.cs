using MusicClasses;

namespace MusicClasses.Interfaces
{
    public interface IMusicDataService
    {
        Task<List<Playlist>> GetUserPlaylistsAsync(int userId);
        Task AddPlaylistAsync(int userId, Playlist newPlaylist);
    }
}

